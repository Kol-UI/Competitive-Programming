using System;
using CompetitiveProgramming.TestDrivenDevelopment;
using Microsoft.VisualBasic;

namespace CompetitiveProgramming.LeetCode.LongestCommonSubsequence
{
    public class Solution
	{
        //Given two strings text1 and text2, return the length of their longest common subsequence.
        //If there is no common subsequence, return 0.

        //A subsequence of a string is a new string generated from the original string with some characters(can be none)
        //    deleted without changing the relative order of the remaining characters.

        //For example, "ace" is a subsequence of "abcde".
        //A common subsequence of two strings is a subsequence that is common to both strings.

        //Examples :

        //Input: text1 = "abcde", text2 = "ace"
        //Output: 3  
        //Explanation: The longest common subsequence is "ace" and its length is 3.
        //Example 2:

        //Input: text1 = "abc", text2 = "abc"
        //Output: 3
        //Explanation: The longest common subsequence is "abc" and its length is 3.
        //Example 3:

        //Input: text1 = "abc", text2 = "def"
        //Output: 0
        //Explanation: There is no such common subsequence, so the result is 0.

        public static int LongestCommonSubsequence(string text1, string text2)
        {
            int a = text1.Length;
            int b = text2.Length;
            if (a == 0 || b == 0)
            {
                return 0;
            }
            var memo = new int[a + 1, b + 1];

            for (int i = 1; i <= a; ++i)
            {
                for (int j = 1; j <= b; ++j)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        memo[i, j] = memo[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        memo[i, j] = Math.Max(memo[i - 1, j], memo[i, j - 1]);
                    }
                }
            }
            return memo[a, b];
        }

        public static bool[] TestLongestCommonSubsequence()
        {
            // Case 1
            string Case1Text1 = "test"; string Case1Text2 = "tesabcde";
            int Case1Result = LeetCode.LongestCommonSubsequence.Solution.LongestCommonSubsequence(Case1Text1, Case1Text2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1Result, 3)
            };
            
            return results;
        }
    }
}

