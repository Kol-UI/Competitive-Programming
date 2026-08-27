Path Combiner

Combines file system path segments into a normalized path string.
Handles separators, redundant slashes, dot segments (. and ..), and root detection.
No real file system is touched — all operations are pure string manipulation.

```cs
public class PathCombiner
{
    // Approach 1: Simple join & normalize
    // Joins segments with the given separator and cleans up redundant slashes.
    // Does not resolve . / .. segments.
    public static string Combine(char separator, params string[] segments)
    {
        if (segments == null || segments.Length == 0)
            throw new ArgumentException("At least one segment required.");

        bool isAbsolute = segments[0].StartsWith('/') || segments[0].StartsWith('\\');

        var parts = segments
            .SelectMany(s => s.Split('/', '\\'))
            .Where(p => p.Length > 0)
            .ToArray();

        var joined = string.Join(separator, parts);
        return isAbsolute ? separator + joined : joined;
    }

    // Approach 2: Normalize with . and .. resolution
    // Resolves current-dir (.) and parent-dir (..) segments.
    public static string Normalize(char separator, params string[] segments)
    {
        if (segments == null || segments.Length == 0)
            throw new ArgumentException("At least one segment required.");

        bool isAbsolute = segments[0].StartsWith('/') || segments[0].StartsWith('\\');

        var raw = segments
            .SelectMany(s => s.Split('/', '\\'))
            .Where(p => p.Length > 0);

        var stack = new Stack<string>();
        foreach (var part in raw)
        {
            if (part == ".")
                continue; // stay in place
            else if (part == "..")
            {
                if (stack.Count > 0 && stack.Peek() != "..")
                    stack.Pop(); // go up one level
                else if (!isAbsolute)
                    stack.Push(".."); // keep leading .. for relative paths
            }
            else
                stack.Push(part);
        }

        var resolved = string.Join(separator, stack.Reverse());
        return isAbsolute ? separator + resolved : (resolved.Length > 0 ? resolved : ".");
    }

    // Approach 3: Platform-aware combine
    // Respects Windows-style drive roots (e.g. "C:\") and resets path on absolute segment.
    public static string PlatformCombine(params string[] segments)
    {
        if (segments == null || segments.Length == 0)
            throw new ArgumentException("At least one segment required.");

        var result = new StringBuilder();

        foreach (var seg in segments)
        {
            if (seg == null) continue;
            var trimmed = seg.Trim();
            if (trimmed.Length == 0) continue;

            // Absolute segment resets the accumulated path
            bool isAbsolute = trimmed.StartsWith('/') || trimmed.StartsWith('\\')
                           || (trimmed.Length >= 2 && trimmed[1] == ':');

            if (isAbsolute)
            {
                result.Clear();
                result.Append(trimmed.TrimEnd('/', '\\'));
            }
            else
            {
                if (result.Length > 0 && result[^1] != '/' && result[^1] != '\\' && result[^1] != ':')
                    result.Append('/');
                result.Append(trimmed.TrimEnd('/', '\\'));
            }
        }

        return result.ToString();
    }
}```