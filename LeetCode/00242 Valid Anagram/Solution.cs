using System;

namespace CompetitiveProgramming.LeetCode.ValidAnagram
{
    public class Solution
    {
        // Given two strings s and t, return true if t is an anagram of s, and false otherwise.
        // An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

        // Example 1:

        // Input: s = "anagram", t = "nagaram"
        // Output: true

        // Example 2:

        // Input: s = "rat", t = "car"
        // Output: false

        public bool IsAnagram(string s, string t)
        {
            var so = s.OrderBy(c => c);
            var to = t.OrderBy(c => c);
            return so.SequenceEqual(to);
        }
    }
}

