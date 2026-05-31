Returns the frequency of chars and numbers in a given string.
```cs
public class CharNumberFrequency
{
    // Foreach Aproach
    public static Dictionary<char, int> GetAlphanumericFrequency(string input)
    {
        var dict = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                char lowC = char.ToLower(c);
                if (dict.ContainsKey(lowC)) dict[lowC]++;
                else dict[lowC] = 1;
            }
        }
        return dict;
    }

    // Linq Approach
    public static Dictionary<char, int> GetAlphanumericFrequencyLinq(string input)
    {
        if (string.IsNullOrEmpty(input))
            return new Dictionary<char, int>();

        return input
            .Where(c => char.IsLetterOrDigit(c))
            .GroupBy(c => char.ToLower(c))
            .ToDictionary(
                group => group.Key, 
                group => group.Count()
            );
    }
}```