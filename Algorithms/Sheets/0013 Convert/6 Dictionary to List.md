Convert a Dictionary to a List.
```cs
public class DictionaryToListConverter
{
    // Linq Approach
    public static List<User>? ConvertWithLinq(Dictionary<int, User> dict)
    {
        if (dict == null) return null;
        return dict.Values.ToList();
    }

    // Without Linq Approach
    public static List<User>? ConvertWithoutLinq(Dictionary<int, User> dict)
    {
        if (dict == null) return null;

        List<User> list = [];
        
        foreach (KeyValuePair<int, User> entry in dict)
        {
            list.Add(entry.Value);
        }
        
        return list;
    }
}```