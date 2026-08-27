namespace CompetitiveProgramming.Algorithms;
// Check if two strings are anagrams of each other.
// Same characters, same frequencies, different order allowed.
public class ValidAnagram
{
    // Approach 1: Sort both strings and compare
    public static bool IsAnagramSort(string s, string t)
    {
        if (s.Length != t.Length) return false;

        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);

        return new string(sArr) == new string(tArr);
    }

    // Approach 2: Frequency fixed-size array for lowercase english letters
    public static bool IsAnagramFrequencyArray(string s, string t)
    {
        if (s.Length != t.Length) return false;

        int[] counts = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i] - 'a']++;
            counts[t[i] - 'a']--;
        }

        foreach (int c in counts)
        {
            if (c != 0) return false;
        }

        return true;
    }

    // Approach 3: Frequency dictionary, works for any character set (unicode, etc.)
    public static bool IsAnagramDictionary(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var counts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            counts[c] = counts.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char c in t)
        {
            if (!counts.ContainsKey(c)) return false;

            counts[c]--;
            if (counts[c] < 0) return false;
        }

        return counts.Values.All(v => v == 0);
    }
}