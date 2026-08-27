Palindrome Anagram

```cs
// Check if the characters of a string can be rearranged to form a palindrome.
// A string can form a palindrome if at most one character has an odd count.
public class PalindromeAnagram
{
    // Approach 1: Fixed-size array for lowercase english letters
    public static bool CanFormPalindromeArray(string s)
    {
        int[] counts = new int[26];

        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        int oddCount = 0;
        foreach (int count in counts)
        {
            if (count % 2 != 0) oddCount++;
        }

        return oddCount <= 1;
    }

    // Approach 2: HashSet 
    public static bool CanFormPalindromeHashSet(string s)
    {
        var oddChars = new HashSet<char>();

        foreach (char c in s)
        {
            if (!oddChars.Add(c))
            {
                oddChars.Remove(c);
            }
        }

        // set holds chars with an odd count; at most one allowed
        return oddChars.Count <= 1;
    }

    // Approach 3: Dictionary
    public static bool CanFormPalindromeDictionary(string s)
    {
        var counts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }

        int oddCount = counts.Values.Count(v => v % 2 != 0);

        return oddCount <= 1;
    }
}```