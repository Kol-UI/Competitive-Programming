Longest Substring Without Repeating Characters

Given a string s, find the length of the longest substring without duplicate characters. 

Example 1 :

input = abcabcbb

output = 3

Explanation: The answer is "abc", with the length of 3.




Example 2 :

input = bbbbb

output = 1

Explanation: The answer is "b", with the length of 1.


Example 3 :

input = pwwkew

output = 3

Explanation: The answer is "wke", with the length of 3.

Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.


```cs
// Brute Force Approch
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                if (IsUnique(s, i, j))
                {
                    maxLength = Math.Max(maxLength, j - i + 1);
                }
            }
        }
        
        return maxLength;
    }

    private bool IsUnique(string s, int start, int end)
    {
        // Use a set to track characters in the current substring
        var chars = new HashSet<char>();
        
        for (int k = start; k <= end; k++)
        {
            // If character is already in the set, it's not unique
            if (chars.Contains(s[k]))
            {
                return false;
            }
            chars.Add(s[k]);
        }
        return true;
    }
}

// Sliding Window HashSet
// Instead of checking every substring, we can maintain a window and move it to the right while ensuring all characters within the window are unique.
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        int i = 0, j = 0;
        var charSet = new HashSet<char>();
        
        while (i < n && j < n)
        {
            if (!charSet.Contains(s[j]))
            {
                // Add new character and expand the window
                charSet.Add(s[j]);
                j++;
                maxLength = Math.Max(maxLength, j - i);
            }
            else
            {
                // Remove from the left and shrink the window
                charSet.Remove(s[i]);
                i++;
            }
        }
        
        return maxLength;
    }
}

// Sliding Window HashMap
// We can use a hash map to track the last seen index of each character, which allows skipping over sections of the string already known to contain non-unique characters.
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        int i = 0;
        var map = new Dictionary<char, int>(); // Map[char] -> last seen index

        for (int j = 0; j < n; j++)
        {
            char c = s[j];
            if (map.ContainsKey(c))
            {
                // Update start of window to new position
                i = Math.Max(i, map[c] + 1);
            }
            map[c] = j;
            maxLength = Math.Max(maxLength, j - i + 1);
        }
        return maxLength;
    }
}
```
