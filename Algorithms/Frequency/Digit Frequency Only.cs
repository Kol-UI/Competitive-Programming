namespace CompetitiveProgramming.Algorithms;

// Linq Approach
public static class DigitFrequencyOnlyLinq
{
    public static Dictionary<char, int> GetDigitFrequency(string input)
    {
        if (string.IsNullOrEmpty(input)) return new Dictionary<char, int>();

        return input
            .Where(c => char.IsDigit(c)) // Keep only digits 0-9
            .GroupBy(c => c)
            .ToDictionary(
                group => group.Key, 
                group => group.Count()
            );
    }
}

// Manual Approach
public static class DigitFrequencyOnlyManual
{
    public static Dictionary<char, int> GetDigitFrequency(string input)
    {
        var frequencyMap = new Dictionary<char, int>();
        if (string.IsNullOrEmpty(input)) return frequencyMap;

        foreach (char c in input)
        {
            // Skip if the character is NOT a digit
            if (!char.IsDigit(c)) continue;

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
}