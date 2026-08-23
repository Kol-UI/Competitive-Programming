Minimum Window Substring

Given two strings s and t, return the shortest substring of s such that every character in t, including duplicates, is present in the substring.

If such a substring does not exist, return an empty string "".

You may assume that the correct output is always unique.


Example 1:

Input: s = "OUZODYXAZV", t = "XYZ"

Output: "YXAZ"

Explanation: "YXAZ" is the shortest substring that includes "X", "Y", and "Z" from string t.


Example 2:

Input: s = "xyz", t = "xyz"

Output: "xyz"


Example 3:

Input: s = "x", t = "xy"

Output: ""


```cs
// Brute Force Approach
public class Solution
{
    // Step 1: Count requirements in t using a frequency dictionary.
    // Step 2: Loop through every possible starting position 'i'.
    // Step 3: Loop through every ending position 'j' to create substrings.
    // Step 4: Check if the current substring contains all characters with required frequencies.
    // Step 5: If valid and smaller than the previous best, update results.
    public string MinWindow(string s, string t)
    {
        if (t == "") return "";

        Dictionary<char, int> countT = new Dictionary<char, int>();
        foreach (char c in t)
        {
            countT[c] = countT.GetValueOrDefault(c, 0) + 1;
        }

        int[] res = { -1, -1 };
        int resLen = int.MaxValue;

        for (int i = 0; i < s.Length; i++)
        {
            Dictionary<char, int> countS = new Dictionary<char, int>();
            for (int j = i; j < s.Length; j++)
            {
                countS[s[j]] = countS.GetValueOrDefault(s[j], 0) + 1;

                bool flag = true;
                foreach (var pair in countT)
                {
                    if (countS.GetValueOrDefault(pair.Key, 0) < pair.Value)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag && (j - i + 1) < resLen)
                {
                    resLen = j - i + 1;
                    res[0] = i;
                    res[1] = j;
                }
            }
        }

        return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
    }
}


// Sliding Window Approach
public class Solution
{
    // Step 1: Pre-calculate character frequencies needed from 't'.
    // Step 2: Use a right pointer 'r' to expand the window and add to 'window' count.
    // Step 3: Track how many unique characters meet the required frequency using 'have'.
    // Step 4: When 'have == need', try to shrink the window from the left 'l' to find the minimum.
    // Step 5: Update result indices whenever a smaller valid window is found.
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(t)) return "";

        Dictionary<char, int> countT = new Dictionary<char, int>();
        foreach (char c in t) countT[c] = countT.GetValueOrDefault(c, 0) + 1;

        Dictionary<char, int> window = new Dictionary<char, int>();
        int have = 0, need = countT.Count;
        int[] res = { -1, -1 };
        int resLen = int.MaxValue;
        int l = 0;

        for (int r = 0; r < s.Length; r++)
        {
            char c = s[r];
            window[c] = window.GetValueOrDefault(c, 0) + 1;

            // If the current char's count matches the required count in T
            if (countT.ContainsKey(c) && window[c] == countT[c])
            {
                have++;
            }

            // Step 4: Shrink the window while it's valid
            while (have == need)
            {
                if ((r - l + 1) < resLen)
                {
                    resLen = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }

                // Remove the character at the left pointer
                char leftChar = s[l];
                window[leftChar]--;
                
                // If removing it breaks the "valid window" condition
                if (countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar])
                {
                    have--;
                }
                l++;
            }
        }

        return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
    }
}

```