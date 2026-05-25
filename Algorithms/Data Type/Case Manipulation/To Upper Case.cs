namespace CompetitiveProgramming.Algorithms;

public class ToUpper
{
    public static string ToUpperCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        return input.ToUpper();
    }
}

// International
public class ToUpperSafe
{
    public static string ToUpperCaseSafe(string input)
    {
        return input?.ToUpperInvariant() ?? string.Empty;
    }
}