namespace CompetitiveProgramming.Algorithms;
// Given a string, check if a permutation of it could form a palindrome.
// A string can form a palindrome if at most one character has an odd count.
// Example: "carrace" -> true ("racecar" is a valid permutation)
public class PalindromicPermutations
{
    // Approach 1: HashSet toggle
    public bool CanPermutePalindromeHashSet(string s)
    {
        var seenOnce = new HashSet<char>();

        foreach (char c in s)
        {
            if (!seenOnce.Add(c))
                seenOnce.Remove(c);
        }

        // at most one char with an odd count is allowed
        return seenOnce.Count <= 1;
    }

    // Approach 2: Dictionary counting
    public bool CanPermutePalindromeDictionary(string s)
    {
        var counts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            counts[c] = counts.GetValueOrDefault(c) + 1;
        }

        int oddCount = 0;

        foreach (int count in counts.Values)
        {
            if (count % 2 != 0)
                oddCount++;
        }

        return oddCount <= 1;
    }
}