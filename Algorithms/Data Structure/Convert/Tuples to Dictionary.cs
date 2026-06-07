namespace CompetitiveProgramming.Algorithms;
public class TupleToDictionaryConverter
{
    // Linq Approach
    public static Dictionary<int, string> ConvertWithLinq((int id, string name)[] tupleArray)
    {
        if (tupleArray == null) return [];
        return tupleArray.ToDictionary(t => t.id, t => t.name);
    }

    // Without Linq Approach
    public static Dictionary<int, string> ConvertWithoutLinq((int id, string name)[] tupleArray)
    {
        var dictionary = new Dictionary<int, string>();
        if (tupleArray == null) return dictionary;

        foreach (var item in tupleArray)
        {
            if (!dictionary.ContainsKey(item.id))
            {
                dictionary.Add(item.id, item.name);
            }
        }

        return dictionary;
    }
}