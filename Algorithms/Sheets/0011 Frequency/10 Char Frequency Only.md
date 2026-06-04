Given a sentence as a string, return frequency of each chars, ignore digits.
```cs
// Linq Approach
public static class CharFrequencyOnlyLinq
{
    public static Dictionary<char, int> GetCharFrequency(string input)
    {
        if (string.IsNullOrEmpty(input)) return new Dictionary<char, int>();

        return input
            .Where(c => !char.IsDigit(c)) // Ignore digits 0-9
            .GroupBy(c => c)              // Group by exact character (case-sensitive)
            .ToDictionary(
                group => group.Key, 
                group => group.Count()
            );
    }
}

// Manual Approach
public static class CharFrequencyOnlyManual
{
    public static Dictionary<char, int> GetCharFrequency(string input)
    {
        var frequencyMap = new Dictionary<char, int>();
        if (string.IsNullOrEmpty(input)) return frequencyMap;

        foreach (char c in input)
        {
            // Skip if the character is a digit
            if (char.IsDigit(c)) continue;

            // Update frequency map
            if (frequencyMap.ContainsKey(c))
            {
                frequencyMap[c]++;
            }
            else
            {
                frequencyMap[c] = 1;
            }
        }

        return frequencyMap;
    }
}```