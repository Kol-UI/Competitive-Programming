Convert an integer to a String.
```cs
public class IntegerToStringConverter
{
    // Simple convert
    public static string ConvertToString(int number)
    {
        return number.ToString();
    }

    // Format ("D5" to get 5 digits : 00042)
    public static string ConvertWithFormat(int number, string format)
    {
        return number.ToString(format);
    }
}```