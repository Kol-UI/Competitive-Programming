Convert a String to an Integer.
```cs
public class StringToIntegerConverter
{
    public static int ConvertWithTryParse(string input, int defaultValue = 0)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        return defaultValue;
    }

    public static int ConvertWithParse(string input)
    {
        return int.Parse(input);
    }
}```