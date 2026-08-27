namespace CompetitiveProgramming.Algorithms;
// Find all start indices of p's anagrams in s using a sliding window.
// Returns indices where a substring of s is an anagram of p.
public class FindAllAnagrams
{
    // Approach 1: Sliding window with frequency array comparison
    public static List<int> FindAnagramsArrayCompare(string s, string p)
    {
        var result = new List<int>();
        if (s.Length < p.Length) return result;

        int[] pCount = new int[26];
        int[] sCount = new int[26];

        foreach (char c in p)
        {
            pCount[c - 'a']++;
        }

        int windowSize = p.Length;

        for (int i = 0; i < s.Length; i++)
        {
            sCount[s[i] - 'a']++;

            // remove the char leaving the window
            if (i >= windowSize)
            {
                sCount[s[i - windowSize] - 'a']--;
            }

            // check window once it reaches full size
            if (i >= windowSize - 1 && sCount.SequenceEqual(pCount))
            {
                result.Add(i - windowSize + 1);
            }
        }

        return result;
    }

    // Approach 2: Sliding window with a "matches" counter (avoids full array compare each step)
    public static List<int> FindAnagramsMatchCounter(string s, string p)
    {
        var result = new List<int>();
        if (s.Length < p.Length) return result;

        int[] diff = new int[26];
        foreach (char c in p)
        {
            diff[c - 'a']++;
        }

        // number of letters still needing a positive count to match
        int need = diff.Count(d => d > 0);
        int windowSize = p.Length;

        for (int i = 0; i < s.Length; i++)
        {
            int idx = s[i] - 'a';
            diff[idx]--;
            if (diff[idx] == 0) need--;
            else if (diff[idx] == -1) need++;

            if (i >= windowSize)
            {
                int leftIdx = s[i - windowSize] - 'a';
                diff[leftIdx]++;
                if (diff[leftIdx] == 0) need--;
                else if (diff[leftIdx] == 1) need++;
            }

            if (i >= windowSize - 1 && need == 0)
            {
                result.Add(i - windowSize + 1);
            }
        }

        return result;
    }
}