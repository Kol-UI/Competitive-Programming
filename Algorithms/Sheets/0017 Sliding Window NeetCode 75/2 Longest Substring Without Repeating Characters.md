
Given a string s, find the length of the longest substring without duplicate characters.

A substring is a contiguous sequence of characters within a string.


Example 1:

Input: s = "zxyzxyz"

Output: 3

Explanation: The string "xyz" is the longest without duplicate characters.


Example 2:

Input: s = "xxxx"

Output: 1


```cs
// Brute Force Approch
public class Solution
{
    // Step 1: Initialize the result to store the maximum length found.
    // Step 2: Iterate through each character as the starting point of a substring.
    // Step 3: For each start point, use a HashSet to track unique characters.
    // Step 4: Iterate forward and break if a duplicate is found.
    // Step 5: Update the maximum length and return the result.
    public int LengthOfLongestSubstring(string s)
    {
        int result = 0; // Initialize result
        for (int i = 0; i < s.Length; i++)
        {
            HashSet<char> charSet = new HashSet<char>();
            for (int j = i; j < s.Length; j++)
            {
                if (charSet.Contains(s[j])) { // If duplicate found, stop the current window
                    break;
                }
                charSet.Add(s[j]); // Add unique character to set
            }
            result = Math.Max(result, charSet.Count); // Update global maximum
        }
        return result;
    }
}

// Sliding Window HashSet Approach
public class Solution
{
    // Step 1: Initialize a HashSet, a left pointer 'l', and the result 'res'.
    // Step 2: Iterate through the string with a right pointer 'r'.
    // Step 3: If s[r] is a duplicate, shrink the window from the left until unique.
    // Step 4: Add the current character s[r] and update the maximum length (r - l + 1).
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> charSet = new HashSet<char>();
        int l = 0; 
        int result = 0;

        for (int r = 0; r < s.Length; r++)
        {
            // While we have a duplicate, remove from the left
            while (charSet.Contains(s[r]))
            {
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]); // Add new char to window
            result = Math.Max(result, r - l + 1); // Calculate window size
        }
        return result;
    }
}

// Sliding Window Optimal Approach
public class Solution
{
    // Step 1: Use a Dictionary to store the last seen index of each character.
    // Step 2: Iterate with pointer 'r'.
    // Step 3: If s[r] was seen, jump pointer 'l' to the right of the last occurrence.
    // Step 4: Update the character's last position and the result.
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> mp = new Dictionary<char, int>();
        int l = 0, result = 0;

        for (int r = 0; r < s.Length; r++)
        {
            if (mp.ContainsKey(s[r]))
            {
                // Move 'l' only if the last occurrence is within current window
                l = Math.Max(mp[s[r]] + 1, l);
            }
            mp[s[r]] = r; // Update index to current
            result = Math.Max(result, r - l + 1);
        }
        return result;
    }
}

```