Invert Dictionary
```cs
public class InvertDictionary
{
    // Inverts a dictionary where values are unique.
    /// If values are duplicated, this will throw an ArgumentException.
    public static Dictionary<V, K> InvertUnique<K, V>(Dictionary<K, V> source) where V : notnull
    {
        return source.ToDictionary(pair => pair.Value, pair => pair.Key);
    }

    // Inverts a dictionary and groups keys that share the same value.
    // Example: { "A": 1, "B": 1 } -> { 1: ["A", "B"] }
    public static Dictionary<V, List<K>> InvertAndGroup<K, V>(Dictionary<K, V> source) where V : notnull
    {
        return source
            .GroupBy(pair => pair.Value)
            .ToDictionary(
                group => group.Key,
                group => group.Select(pair => pair.Key).ToList()
            );
    }
}```