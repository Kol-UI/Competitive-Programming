// Minimum Insertion Steps to Make a String Palindrome

/*
Given a string s. In one step you can insert any character at any index of the string.

Return the minimum number of steps to make s palindrome.

A Palindrome String is one that reads the same backward as well as forward.

 

Example 1:

Input: s = "zzazz"
Output: 0
Explanation: The string "zzazz" is already palindrome we do not need any insertions.

Example 2:

Input: s = "mbadm"
Output: 2
Explanation: String can be "mbdadbm" or "mdbabdm".

Example 3:

Input: s = "leetcode"
Output: 5
Explanation: Inserting 5 characters the string becomes "leetcodocteel".
 

Constraints:

1 <= s.length <= 500
s consists of lowercase English letters.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumInsertionStepstoMakeaStringPalindrome
{
    public class Solution
    {
        public static int MinInsertions(string s)
        {
            var dp = new int[s.Length][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[s.Length];
            }

            return Solver(dp, s, 0, s.Length - 1);
        }

        private static int Solver(int[][] dp, string s, int i, int k)
        {
            var result = 0;

            if (i >= k)
            {
                return result;
            }   

            if (dp[i][k] > 0)
            {
                return dp[i][k];
            }

            if (s[i] == s[k])
            {
                result = Solver(dp, s, i + 1, k - 1);
            }
            else
            {
                result = Math.Min(Solver(dp, s, i+1, k), Solver(dp, s, i, k-1)) + 1;
            }

            dp[i][k] = result;
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestDecryptStringfromAlphabettoIntegerMapping()
        {
            // Case 1
            int Case1_1312 = Solution.MinInsertions("zzazz");

            // Case 2
            int Case2_1312 = Solution.MinInsertions("mbadm");

            // Case 3
            int Case3_1312 = Solution.MinInsertions("leetcode");
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1312, 0),
                ResultTester.CheckResult<int>(Case2_1312, 2),
                ResultTester.CheckResult<int>(Case3_1312, 5)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Insertion Steps to Make a String Palindrome");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestDecryptStringfromAlphabettoIntegerMapping());
        }
    }
}