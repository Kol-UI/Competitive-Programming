Convert String to Char Array and Convert Char Array to String.
```cs
public class StringCharConverter
{
    // String to char[]
    public static char[]? ConvertToCharArray(string str)
    {
        return str?.ToCharArray();
    }

    // char[] to String
    public static string? ConvertToString(char[] chars)
    {
        if (chars == null) return null;
        return new string(chars);
    }

    // Span Approach
    public static string? ConvertToStringAsSpan(char[] chars)
    {
        return chars == null ? null : new string(chars.AsSpan());
    }
}```