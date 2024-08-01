// Interleaving String

/*
Given strings s1, s2, and s3, find whether s3 is formed by an interleaving of s1 and s2.

An interleaving of two strings s and t is a configuration where s and t are divided into n and m 
substrings
 respectively, such that:

s = s1 + s2 + ... + sn
t = t1 + t2 + ... + tm
|n - m| <= 1
The interleaving is s1 + t1 + s2 + t2 + s3 + t3 + ... or t1 + s1 + t2 + s2 + t3 + s3 + ...
Note: a + b is the concatenation of strings a and b.

 

Example 1:


Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac"
Output: true
Explanation: One way to obtain s3 is:
Split s1 into s1 = "aa" + "bc" + "c", and s2 into s2 = "dbbc" + "a".
Interleaving the two splits, we get "aa" + "dbbc" + "bc" + "a" + "c" = "aadbbcbcac".
Since s3 can be obtained by interleaving s1 and s2, we return true.

Example 2:

Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbbaccc"
Output: false
Explanation: Notice how it is impossible to interleave s2 with any other string to obtain s3.

Example 3:

Input: s1 = "", s2 = "", s3 = ""
Output: true
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.InterleavingString
{
    public class Solution
    {
        static int[][][]? dp;
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            int l1 = s1.Length;
            int l2 = s2.Length;
            int l3 = s3.Length;

            if(l3 != l1 + l2)
                return false;
            
            dp = new int[l1][][];

            for(int i = 0; i < l1; i++)
            {
                dp[i] = new int[l2][];
                for(int j = 0; j < l2; j++)
                {
                    dp[i][j] = new int[l3];
                }
            }

            return CheckInterleave(l1 - 1, l2 - 1, l3 - 1, s1, s2, s3);
        }

        private static bool CheckInterleave(int i1, int i2, int i3, string s1, string s2, string s3)
        {
            if(i1 < 0 && i2 < 0 && i3 < 0)
                return true;
            
            if(i1 >= 0 && i2 >= 0 && i3 >= 0 && dp![i1][i2][i3] != 0)
                return dp[i1][i2][i3] == 1;

            bool result = false;

            if(i1 >= 0 && s1[i1] == s3[i3])
                result = result | CheckInterleave(i1 - 1, i2, i3 - 1, s1, s2, s3);
            
            if(i2 >= 0 && s2[i2] == s3[i3])
                result = result | CheckInterleave(i1, i2 - 1, i3 - 1, s1, s2, s3);
            
            if(i1 >= 0 && i2 >= 0 && i3 >= 0)
                dp![i1][i2][i3] = result == true ? 1 : -1;

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string s1_1 = "aabcc";
            string s2_1 = "dbbca";
            string s3_1 = "aadbbcbcac";
            string s1_2 = "aabcc";
            string s2_2 = "dbbca";
            string s3_2 = "aadbbbaccc";
            string s1_3 = "";
            string s2_3 = "";
            string s3_3 = "";
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsInterleave(s1_1, s2_1, s3_1), true),
                ResultTester.CheckResult<bool>(Solution.IsInterleave(s1_2, s2_2, s3_2), false),
                ResultTester.CheckResult<bool>(Solution.IsInterleave(s1_3, s2_3, s3_3), true),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Interleaving String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}