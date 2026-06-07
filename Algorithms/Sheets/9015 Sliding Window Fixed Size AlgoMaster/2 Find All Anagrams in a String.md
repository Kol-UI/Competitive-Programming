Find All Anagrams in a String

Given two strings s and p, return an array of all the start indices of p's anagrams in s.

You may return the answer in any order. 


Example 1 :

Input: s = "cbaebabacd", p = "abc"

Output: [0,6]


Explanation:

The substring with start index = 0 is "cba", which is an anagram of "abc".

The substring with start index = 6 is "bac", which is an anagram of "abc".


Example 2:

Input: s = "abab", p = "ab"

Output: [0,1,2]


Explanation:

The substring with start index = 0 is "ab", which is an anagram of "ab".

The substring with start index = 1 is "ba", which is an anagram of "ab".The substring with start index = 2 is "ab", which is an anagram of "ab".



```cs
public class FindAllAnagramsinaString_FrequenciesArrays
{
    public IList<int> FindAnagrams(string s, string p) 
    {
        var result = new List<int>();
        if (s.Length < p.Length) return result;
        int[] frequenciesP = new int[26];
        int[] frequenciesS = new int[26];
        frequenciesP = CountCharacter(p);
        frequenciesS = CountCharacter(s[..p.Length]);

        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            if (Enumerable.SequenceEqual(frequenciesP, frequenciesS)) result.Add(i);
            // Sliding
            if (i < s.Length - p.Length)
            {
                frequenciesS[s[i] - 'a']--; // leaving char
                frequenciesS[s[i + p.Length] - 'a']++; // entering char
            }
        }

        return result;
    }

    private static int[] CountCharacter(string s)
    {
        var count = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
        }
        return count;
    }
}
```

```cs
public class FindAllAnagramsinaString_FrequenciesArrays2
{
    public IList<int> FindAnagrams(string s, string p)
    {
        var result = new List<int>();
        int n = s.Length, k = p.Length;
        if (n < k) return result;

        int[] freqP = new int[26];
        int[] freqS = new int[26];

        foreach (char c in p) freqP[c - 'a']++;

        for (int i = 0; i < n; i++)
        {
            freqS[s[i] - 'a']++;

            if (i >= k) 
            {
                freqS[s[i - k] - 'a']--;
            }

            if (i >= k - 1) 
            {
                if (Enumerable.SequenceEqual(freqS, freqP)) 
                {
                    result.Add(i - k + 1);
                }
            }
        }
        return result;
    }
}
```