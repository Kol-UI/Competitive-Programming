File Extension Filter

Filters a list of file name strings by their extension.

```cs
// Approach 1 uses simple string matching (case-insensitive, single extension).
// Approach 2 supports multiple extensions and optional dot-prefix normalization.
// Approach 3 groups files by extension into a dictionary for bulk categorization.

public class FileExtensionFilter
{
    // Approach 1: Single extension filter
    // Returns files whose extension matches, case-insensitive.
    public static IEnumerable<string> FilterByExtension(IEnumerable<string> files, string extension)
    {
        if (files == null) throw new ArgumentNullException(nameof(files));
        if (string.IsNullOrWhiteSpace(extension))
            throw new ArgumentException("Extension must not be empty.");

        var normalized = NormalizeExt(extension);
        return files.Where(f => GetExtension(f).Equals(normalized, StringComparison.OrdinalIgnoreCase));
    }

    // Approach 2: Multi-extension filter
    // Returns files matching any of the given extensions.
    public static IEnumerable<string> FilterByExtensions(IEnumerable<string> files, params string[] extensions)
    {
        if (files == null) throw new ArgumentNullException(nameof(files));
        if (extensions == null || extensions.Length == 0)
            throw new ArgumentException("At least one extension required.");

        var normalized = extensions.Select(NormalizeExt).ToHashSet(StringComparer.OrdinalIgnoreCase);
        return files.Where(f => normalized.Contains(GetExtension(f)));
    }

    // Approach 3: Group by extension
    // Returns a dictionary mapping each extension to its matching files.
    public static Dictionary<string, List<string>> GroupByExtension(IEnumerable<string> files)
    {
        if (files == null) throw new ArgumentNullException(nameof(files));

        var result = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        foreach (var file in files)
        {
            var ext = GetExtension(file);
            if (!result.TryGetValue(ext, out var list))
            {
                list = new List<string>();
                result[ext] = list;
            }
            list.Add(file);
        }
        return result;
    }

    // Extracts the extension including the dot; returns "" if none.
    private static string GetExtension(string fileName)
    {
        if (string.IsNullOrEmpty(fileName)) return "";
        int dot = fileName.LastIndexOf('.');
        // dot must not be the first char (hidden files like ".gitignore") or last
        if (dot <= 0 || dot == fileName.Length - 1) return "";
        return fileName[dot..];
    }

    // Ensures the extension starts with a dot.
    private static string NormalizeExt(string ext) => ext.StartsWith('.') ? ext : "." + ext;
}```