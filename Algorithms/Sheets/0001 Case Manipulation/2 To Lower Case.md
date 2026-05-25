Convert a string to lower case.

```cs
public class ToLower
{
    public static string ToLowerCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        return input.ToLower();
    }
}

// International
public class ToLowerSafe
{
    public static string ToLowerCaseSafe(string input)
    {
        return input?.ToLowerInvariant() ?? string.Empty;
    }
}
```
