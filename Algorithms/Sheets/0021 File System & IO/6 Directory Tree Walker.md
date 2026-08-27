Directory Tree Walker

```cs
// Problem: given a flat list of paths (e.g. "a/b/c.txt"), build an indented
// tree string. Each depth level adds 2 spaces. Children are sorted alphabetically,
// folders are listed before files at the same level.
// Example input: ["a/b/c.txt", "a/e.txt"]
// Example output:
// a
//   b
//     c.txt
//   e.txt

// Approach 1 : Recursive
public class DirectoryTreeWalkerRecursive
{
    private class Node
    {
        public Dictionary<string, Node> Children { get; } = new();
        public bool IsFile { get; set; }
    }

    public string BuildTree(IEnumerable<string> paths)
    {
        var root = new Node();

        foreach (var path in paths)
        {
            if (string.IsNullOrWhiteSpace(path))
                continue;

            var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var current = root;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!current.Children.TryGetValue(parts[i], out var child))
                {
                    child = new Node();
                    current.Children[parts[i]] = child;
                }

                // last segment is a file, the rest are folders
                if (i == parts.Length - 1)
                    child.IsFile = true;

                current = child;
            }
        }

        var sb = new StringBuilder();
        Append(root, 0, sb);

        // remove trailing newline
        if (sb.Length > 0)
            sb.Length--;

        return sb.ToString();
    }

    private void Append(Node node, int depth, StringBuilder sb)
    {
        // folders first, then files, alphabetically within each group
        var ordered = node.Children
            .OrderBy(kv => kv.Value.IsFile && kv.Value.Children.Count == 0)
            .ThenBy(kv => kv.Key, StringComparer.Ordinal);

        foreach (var (name, child) in ordered)
        {
            sb.Append(' ', depth * 2);
            sb.Append(name);
            sb.Append('\n');
            Append(child, depth + 1, sb);
        }
    }
}

// Approach 2 : Iterative
public class DirectoryTreeWalkerIterative
{
    private class Entry
    {
        public string Name;
        public int Depth;
        public bool IsFolder;
    }

    public string BuildTree(IEnumerable<string> paths)
    {
        // build a sorted set of (depth, name) entries using a stack, no recursion
        var folderPaths = new SortedSet<string>(StringComparer.Ordinal);
        var allEntries = new List<(string fullPath, bool isFolder)>();

        foreach (var path in paths)
        {
            if (string.IsNullOrWhiteSpace(path))
                continue;

            var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            string accumulated = "";

            for (int i = 0; i < parts.Length; i++)
            {
                accumulated = i == 0 ? parts[i] : accumulated + "/" + parts[i];
                bool isFolder = i < parts.Length - 1;

                if (isFolder)
                    folderPaths.Add(accumulated);
                else if (!allEntries.Any(e => e.fullPath == accumulated))
                    allEntries.Add((accumulated, false));
            }
        }

        foreach (var folder in folderPaths)
            allEntries.Add((folder, true));

        var sb = new StringBuilder();
        foreach (var entry in SortByTreeOrder(allEntries))
        {
            sb.Append(' ', entry.Depth * 2);
            sb.Append(entry.Name);
            sb.Append('\n');
        }

        if (sb.Length > 0)
            sb.Length--;

        return sb.ToString();
    }

    private List<Entry> SortByTreeOrder(List<(string fullPath, bool isFolder)> allEntries)
    {
        // group children by parent path, then walk depth-first with a stack
        var byParent = new Dictionary<string, List<(string fullPath, bool isFolder)>>();

        foreach (var item in allEntries)
        {
            int lastSlash = item.fullPath.LastIndexOf('/');
            string parent = lastSlash >= 0 ? item.fullPath.Substring(0, lastSlash) : "";

            if (!byParent.TryGetValue(parent, out var list))
            {
                list = new List<(string, bool)>();
                byParent[parent] = list;
            }

            list.Add(item);
        }

        var result = new List<Entry>();
        var stack = new Stack<(string fullPath, int depth)>();

        // push root level children in reverse sorted order (folders first) so popping gives correct order
        foreach (var item in OrderSiblings(byParent.GetValueOrDefault("", new())))
            stack.Push((item.fullPath, 0));

        while (stack.Count > 0)
        {
            var (fullPath, depth) = stack.Pop();
            bool isFolder = byParent.ContainsKey(fullPath);
            string name = fullPath.Split('/').Last();

            result.Add(new Entry { Name = name, Depth = depth, IsFolder = isFolder });

            if (isFolder)
            {
                foreach (var child in OrderSiblings(byParent[fullPath]))
                    stack.Push((child.fullPath, depth + 1));
            }
        }

        return result;
    }

    private IEnumerable<(string fullPath, bool isFolder)> OrderSiblings(List<(string fullPath, bool isFolder)> siblings)
    {
        // files before folders here because the stack reverses order on pop
        return siblings
            .OrderByDescending(s => s.isFolder ? 0 : 1)
            .ThenByDescending(s => s.fullPath, StringComparer.Ordinal);
    }
}```