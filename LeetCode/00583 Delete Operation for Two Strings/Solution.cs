// Delete Operation for Two Strings

/*
Given two strings word1 and word2, return the minimum number of steps required to make word1 and word2 the same.

In one step, you can delete exactly one character in either string.

 

Example 1:

Input: word1 = "sea", word2 = "eat"
Output: 2
Explanation: You need one step to make "sea" to "ea" and another step to make "eat" to "ea".

Example 2:

Input: word1 = "leetcode", word2 = "etco"
Output: 4
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DeleteOperationforTwoStrings
{
    public class Solution
    {
        public static int MinDistance(string word1, string word2)
        {
            int m = word1.Length;
            int n = word2.Length;
            int?[,] dp = new int?[m, n];
            return Backtrack(0, 0);

            int Backtrack(int left, int right)
            {
                if (left == m || right == n) return m - left + n - right;

                return dp[left, right] ??= word1[left] == word2[right]
                    ? Backtrack(left + 1, right + 1)
                    : 1 + Math.Min(Backtrack(left + 1, right), Backtrack(left, right + 1));
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string word1_1 = "sea";
            string word2_1 = "eat";

            string word1_2 = "leetcode";
            string word2_2 = "etco";
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinDistance(word1_1, word2_1), 2),
                ResultTester.CheckResult<int>(Solution.MinDistance(word1_2, word2_2), 4),
            };
            return results;
        }
    }
}