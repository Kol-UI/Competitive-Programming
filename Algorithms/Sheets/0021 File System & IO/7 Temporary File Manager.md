Temporary File Manager

```cs
// Files are created with a name, content and a TTL (time-to-live).
// At a given "current time", a file is considered expired if currentTime >= expiry.
// Expired files cannot be read and are treated as deleted.


// Approach 1 : Dictionary
public class TemporaryFileManager
{
    // name -> (content, expiryTime)
    private readonly Dictionary<string, (string Content, int Expiry)> _files = new();

    public void Create(string name, string content, int currentTime, int ttl)
    {
        _files[name] = (content, currentTime + ttl);
    }

    public string? Read(string name, int currentTime)
    {
        if (!_files.TryGetValue(name, out var file))
            return null;

        if (currentTime >= file.Expiry)
        {
            _files.Remove(name);
            return null;
        }

        return file.Content;
    }

    public bool Delete(string name)
    {
        return _files.Remove(name);
    }

    public int CountActive(int currentTime)
    {
        // Lazy cleanup happens here too
        var expired = _files.Where(kv => currentTime >= kv.Value.Expiry).Select(kv => kv.Key).ToList();
        foreach (var key in expired)
            _files.Remove(key);

        return _files.Count;
    }
}

// Approach 2 : Dictionary + SortedSet
// Optimized version : keeps a sorted structure of (expiry, name) pairs
// to purge expired files in O(log n) instead of scanning everything.
public class TemporaryFileManagerOptimized
{
    private readonly Dictionary<string, (string Content, int Expiry)> _files = new();
    private readonly SortedSet<(int Expiry, string Name)> _expiryIndex = new();

    public void Create(string name, string content, int currentTime, int ttl)
    {
        // Remove old entry from index if file already existed
        if (_files.TryGetValue(name, out var old))
            _expiryIndex.Remove((old.Expiry, name));

        var expiry = currentTime + ttl;
        _files[name] = (content, expiry);
        _expiryIndex.Add((expiry, name));
    }

    public string? Read(string name, int currentTime)
    {
        Purge(currentTime);

        if (!_files.TryGetValue(name, out var file))
            return null;

        return file.Content;
    }

    public bool Delete(string name)
    {
        if (!_files.TryGetValue(name, out var file))
            return false;

        _expiryIndex.Remove((file.Expiry, name));
        _files.Remove(name);
        return true;
    }

    public int CountActive(int currentTime)
    {
        Purge(currentTime);
        return _files.Count;
    }

    // Remove every entry whose expiry is <= currentTime
    private void Purge(int currentTime)
    {
        while (_expiryIndex.Count > 0 && _expiryIndex.Min.Expiry <= currentTime)
        {
            var (expiry, name) = _expiryIndex.Min;
            _expiryIndex.Remove((expiry, name));
            _files.Remove(name);
        }
    }
}```