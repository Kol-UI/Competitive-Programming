Permutation in String

Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.

In other words, return true if one of s1's permutations is the substring of s2.


Example 1:

Input: s1 = "ab", s2 = "eidbaooo"

Output: true

Explanation: s2 contains one permutation of s1 ("ba").


Example 2:

Input: s1 = "ab", s2 = "eidboaoo"

Output: false 



```cs

// Brute Force Sorting Approch
// Sort strings to compare
public class PermutationInString_BruteForceSorting
{
    public bool CheckInclusion(string s1, string s2)
    {
        char[] s1Arr = s1.ToCharArray();
        Array.Sort(s1Arr);
        string sortedS1 = new(s1Arr);

        for (int i = 0; i < s2.Length; i++)
        {
            for (int j = i; j < s2.Length; j++)
            {
                char[] subStrArr = s2.Substring(i, j - i + 1).ToCharArray();
                Array.Sort(subStrArr);
                string sortedSubStr = new(subStrArr);
                if (sortedSubStr == sortedS1) return true;
            }
        }
        return false;
    }
}

// Brute Force Recursive Approch
// Generate all permutations of s1
// Then check each to see if exists as a s2 substring
// if s1 = "abc" then generate abc, acb, bac, bca, cab, cba
public class PermutationInString_BruteForceRecursive
{
    public bool CheckInclusion(string s1, string s2) 
    {
        return Permute(string.Empty, s1, s2);
    }

    private bool Permute(string prefix, string s1Rest, string s2)
    {
        int len = s1Rest.Length;
        if (len == 0) return s2.Contains(prefix);
        else
        {
            for (int i = 0; i < len; i++)
            {
                string nextPrefix = prefix + s1Rest[i];
                string nextRest = s1Rest.Substring(0, i) + s1Rest.Substring(i + 1);
                if (Permute(nextPrefix, nextRest, s2)) return true;
            }
        }
        return false;
    }
}

// Hash Counting Approch
public class PermutationInString_HashCounting
{
    public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> count1 = [];
        foreach (char c in s1) 
        {
            if (count1.ContainsKey(c))
            {
                count1[c]++;
            }
            else
            {
                count1[c] = 1;
            }
        }

        int need = count1.Count;
        for (int i = 0; i < s2.Length; i++)
        {
            Dictionary<char, int> count2 = [];
            int current = 0;
            for (int j = i; j < s2.Length; j++)
            {
                char c = s2[j];
                if (count2.ContainsKey(c)) 
                {
                    count2[c]++;
                } 
                else
                {
                    count2[c] = 1;
                }

                if (!count1.ContainsKey(c) || count1[c] < count2[c]) break;
                if (count1[c] == count2[c]) current++;
                if (current == need) return true;
            }
        }
        return false;
    }
}

// Sliding Window Char Freq Approch
/*
    s1 = "ab" (len = 2)
    s2 = "eidbaooo"

    [EI]DBAOOO = false
    E[ID]BAOOO = false
    EI[DB]AOOO = false
    EID[BA]OOO = true !
*/
public class PermutationInString_SlidingWindow
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        for (int i = 0; i < s2.Length - s1.Length; i++)
        {
            if (Matches(s1Count, s2Count)) return true;
            s2Count[s2[i + s1.Length] - 'a']++;
            s2Count[s2[i] - 'a']--;
        }

        return Matches(s1Count, s2Count);
    }

    private bool Matches(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++) if (a[i] != b[i]) return false;
        return true;
    }
}
```
