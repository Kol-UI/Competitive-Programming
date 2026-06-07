namespace CompetitiveProgramming.Algorithms;
public class PairToDictionaryConverter
{
    // Linq Approach
    public static Dictionary<int, string>? ConvertWithLinq(KeyValuePair<int, string>[] pairs)
    {
        if (pairs == null) return null;
        return pairs.ToDictionary(pair => pair.Key, pair => pair.Value);
    }

    // Linq Approach
    public static Dictionary<int, string>? ConvertWithoutLinq(KeyValuePair<int, string>[] pairs)
    {
        if (pairs == null) return null;
        var dictionary = new Dictionary<int, string>();

        foreach (var pair in pairs)
        {
            if (!dictionary.ContainsKey(pair.Key))
            {
                dictionary.Add(pair.Key, pair.Value);
            }
        }

        return dictionary;
    }
}