namespace CompetitiveProgramming.Algorithms;

public class Frequency
{
    public static void PrintFrequencies(Dictionary<int, int> frequencies)
    {
        foreach (var kvp in frequencies) Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
    }

    public static Dictionary<int, int> GetFrequencies(int[] values)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int value in values)
        {
            dict.TryGetValue(value, out int count);
            dict[value] = count + 1;
        }
        return dict;
    }

    public static Dictionary<int, int> GetFrequenciesWithIgnoredValue(int[] values, int ignore = int.MinValue)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int value in values)
        {
            if (value == ignore) continue;
            dict.TryGetValue(value, out int count);
            dict[value] = count + 1;
        }
        return dict;
    }

    public static Dictionary<int, int> GetFrequenciesWithIgnoredValues(int[] values, HashSet<int> ignoredValues)
    {
        var dict = new Dictionary<int, int>();
        foreach (int value in values)
        {
            if (ignoredValues.Contains(value)) continue;
            dict.TryGetValue(value, out int count);
            dict[value] = count + 1;
        }
        return dict;
    }
    
    public static Dictionary<int, int> SortDictionaryByKey(Dictionary<int, int> dict)
    {
        var sortedKeys = new List<int>(dict.Keys);
        sortedKeys.Sort();

        var sortedDict = new Dictionary<int, int>();
        foreach (var key in sortedKeys)
        {
            sortedDict[key] = dict[key];
        }
        return sortedDict;
    }

    public static Dictionary<int, int> SortDictionaryByKeyDesc(Dictionary<int, int> dict)
    {
        var sortedKeys = new List<int>(dict.Keys);
        sortedKeys.Sort((a, b) => b.CompareTo(a));

        var sortedDict = new Dictionary<int, int>();
        foreach (var key in sortedKeys)
        {
            sortedDict[key] = dict[key];
        }
        return sortedDict;
    }

    public static Dictionary<int, int> SortDictionaryByValue(Dictionary<int, int> dict)
    {
        var sortedPairs = new List<KeyValuePair<int, int>>(dict);
        sortedPairs.Sort((a, b) => a.Value.CompareTo(b.Value));

        var sortedDict = new Dictionary<int, int>();
        foreach (var kvp in sortedPairs)
        {
            sortedDict[kvp.Key] = kvp.Value;
        }
        return sortedDict;
    }

    public static Dictionary<int, int> SortDictionaryByValueDesc(Dictionary<int, int> dict)
    {
        var sortedPairs = new List<KeyValuePair<int, int>>(dict);
        sortedPairs.Sort((a, b) => b.Value.CompareTo(a.Value));

        var sortedDict = new Dictionary<int, int>();
        foreach (var kvp in sortedPairs)
        {
            sortedDict[kvp.Key] = kvp.Value;
        }
        return sortedDict;
    }
}