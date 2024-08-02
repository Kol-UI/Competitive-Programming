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
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestLongestPalindromicSubsequence()
        {
            // Case 1
            string s516_1 = "bbbab";
            int output516_1 = Solution.LongestPalindromeSubseq(s516_1);

            // Case 2
            string s516_2 = "cbbd";
            int output516_2 = Solution.LongestPalindromeSubseq(s516_2);

            // Case 3
            string s516_3 = "noon";
            int output516_3 = Solution.LongestPalindromeSubseq(s516_3);

            // Case 4
            string s516_4 = "civic";
            int output516_4 = Solution.LongestPalindromeSubseq(s516_4);

            // Case 5
            string s516_5 = "racecar";
            int output516_5 = Solution.LongestPalindromeSubseq(s516_5);

            // Case 6
            string s516_6 = "level";
            int output516_6 = Solution.LongestPalindromeSubseq(s516_6);

            // Case 7
            string s516_7 = "mom";
            int output516_7 = Solution.LongestPalindromeSubseq(s516_7);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(output516_1, 4),
                ResultTester.CheckResult<int>(output516_2, 2),
                ResultTester.CheckResult<int>(output516_3, output516_3),
                ResultTester.CheckResult<int>(output516_4, output516_4),
                ResultTester.CheckResult<int>(output516_5, output516_5),
                ResultTester.CheckResult<int>(output516_6, output516_6),
                ResultTester.CheckResult<int>(output516_7, output516_7),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Longest Palindromic Subsequence");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestLongestPalindromicSubsequence());
        }
    }
}