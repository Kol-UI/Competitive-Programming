// Longest Palindromic Subsequence

/*
Given a string s, find the longest palindromic subsequence's length in s.

A subsequence is a sequence that can be derived from another sequence by deleting some or no elements without changing the order of the remaining elements.


Example 1:
Input: s = "bbbab"
Output: 4
Explanation: One possible longest palindromic subsequence is "bbbb".

Example 2:
Input: s = "cbbd"
Output: 2
Explanation: One possible longest palindromic subsequence is "bb".
*/

using System;
namespace CompetitiveProgramming.LeetCode.LongestPalindromicSubsequence
{
    public class Solution
    {
        public static int LongestPalindromeSubseq(string s)
        {
            int n = s.Length;
            Dictionary<(int, int), int> cache = new();
            return LongestSubsequence(0, n - 1, s, cache);
        }

        public static int LongestSubsequence(int i, int j, string s, Dictionary<(int, int), int> cache)
        {
            if (cache.ContainsKey((i, j)))
            {
                return cache[(i, j)];
            }

            if (i > j)
            {
                return 0;
            }
            if (i == j)
            {
                return 1;
            }

            if (s[i] == s[j])
            {
                cache[(i, j)] = 2 + LongestSubsequence(i + 1, j - 1, s, cache);
                return cache[(i, j)];
            }

            int left = LongestSubsequence(i, j - 1, s, cache);
            int right = LongestSubsequence(i + 1, j, s, cache);
            cache[(i, j)] = Math.Max(left, right);
            return Math.Max(left, right);
        }
    }
}