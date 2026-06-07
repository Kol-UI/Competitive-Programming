List to Dictionary Convert a list to a dictionary.
```cs
// Linq Approach
public class ListToDictionaryConverter
{
    public static Dictionary<int, User>? ConvertToDict(List<User> users)
    {
        if (users == null) return null;

        // ToDictionary(key, value)
        // u => u.Id key
        // u => u object as value
        return users.ToDictionary(u => u.Id, u => u);
    }
}

// Manual Approach
public class ListToDictionaryManual
{
    public static Dictionary<int, User>? ConvertToDict(List<User> users)
    {
        if (users == null) return null;

        var dictionary = new Dictionary<int, User>();

        foreach (var user in users)
        {
            if (!dictionary.ContainsKey(user.Id))
            {
                dictionary.Add(user.Id, user);
            }
        }

        return dictionary;
    }
}```