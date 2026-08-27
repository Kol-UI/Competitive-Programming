Anagram Deletions Minimum Steps

```cs
// Find the minimum number of character deletions (from either string)
// needed so that both strings become anagrams of each other.
public class AnagramDeletionsMinimumSteps
{
    // Approach 1: Fixed-size array for lowercase english letters
    public static int MinStepsFrequencyArray(string s, string t)
    {
        int[] counts = new int[26];

        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        foreach (char c in t)
        {
            counts[c - 'a']--;
        }

        // sum of absolute differences = total chars to delete
        int steps = 0;
        foreach (int count in counts)
        {
            steps += Math.Abs(count);
        }

        return steps;
    }

    // Approach 2: Dictionary, works for any character set
    public static int MinStepsDictionary(string s, string t)
    {
        var counts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char c in t)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) - 1;
        }

        return counts.Values.Sum(v => Math.Abs(v));
    }
}```