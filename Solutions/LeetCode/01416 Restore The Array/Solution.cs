// Restore The Array

/*
A program was supposed to print an array of integers. The program forgot to print whitespaces and the array is printed as a string of digits s and all we know is that all integers in the array were in the range [1, k] and there are no leading zeros in the array.

Given the string s and the integer k, return the number of the possible arrays that can be printed as s using the mentioned program. Since the answer may be very large, return it modulo 109 + 7.

 

Example 1:

Input: s = "1000", k = 10000
Output: 1
Explanation: The only possible array is [1000]

Example 2:

Input: s = "1000", k = 10
Output: 0
Explanation: There cannot be an array that was printed this way and has all integer >= 1 and <= 10.

Example 3:

Input: s = "1317", k = 2000
Output: 8
Explanation: Possible arrays are [1317],[131,7],[13,17],[1,317],[13,1,7],[1,31,7],[1,3,17],[1,3,1,7]
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RestoreTheArray
{
    public class Solution
    {
        public static int NumberOfArrays(string s, int k)
        {
            int mod = 1000000007;
            int n = s.Length;
            long[] dp = new long[n+1];
            dp[n] = 1;
            for (int i = n-1; i >= 0; i--)
            {
                if (s[i] == '0')
                {
                    dp[i] = 0;
                }
                else
                {
                    long num = 0;
                    for (int j = i; j < n; j++)
                    {
                        num = num * 10 + (s[j] - '0');
                        if (num > k) break;
                        dp[i] = (dp[i] + dp[j+1]) % mod;
                    }
                }
            }
            return (int) dp[0];
        }
    }

    public class Test
    {
        public static bool[] TestRestoreTheArray()
        {
            // Case 1
            int Case1_1416 = Solution.NumberOfArrays("1000", 10000);

            // Case 2
            int Case2_1416 = Solution.NumberOfArrays("1000", 10);

            // Case 3
            int Case3_1416 = Solution.NumberOfArrays("1317", 200);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1416, 1),
                ResultTester.CheckResult<int>(Case2_1416, 0),
                ResultTester.CheckResult<int>(Case3_1416, 6)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Restore The Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestRestoreTheArray());
        }
    }
}