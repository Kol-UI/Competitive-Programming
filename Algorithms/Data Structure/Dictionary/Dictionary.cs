namespace CompetitiveProgramming.Algorithms;

public class Dictionary
{
    public static SortedDictionary<int, int> ToSortedDictionary(Dictionary<int, int> dict) => new SortedDictionary<int, int>(dict);
    public static Dictionary<int, int> SortDictionaryByKey(Dictionary<int, int> dict) => dict.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    public static Dictionary<int, int> SortDictionaryByKeyDesc(Dictionary<int, int> dict) => dict.OrderByDescending(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    public static Dictionary<int, int> SortDictionaryByValue(Dictionary<int, int> dict) => dict.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    public static Dictionary<int, int> SortDictionaryByValueDesc(Dictionary<int, int> dict) => dict.OrderByDescending(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
}