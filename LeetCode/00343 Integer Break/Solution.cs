// Integer Break

/*
Given an integer n, break it into the sum of k positive integers, where k >= 2, and maximize the product of those integers.

Return the maximum product you can get.

 

Example 1:

Input: n = 2
Output: 1
Explanation: 2 = 1 + 1, 1 × 1 = 1.
Example 2:

Input: n = 10
Output: 36
Explanation: 10 = 3 + 3 + 4, 3 × 3 × 4 = 36.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IntegerBreak
{
    public class Solution
    {
        public static int IntegerBreak(int n) 
        {
            var dp = new int [n + 1];

            for(var k = 2; k <= n; k++)
            {
                var (left, right) = (1, k - 1);

                for(int prev = -1; prev < dp[k]; left++, right--)
                {
                    prev = dp[k];

                    var curr = Math.Max(left, dp[left]) * 
                            Math.Max(right, dp[right]);

                    dp[k] = Math.Max(curr, dp[k]);    
                }
            }

            return dp[^1];
        }
    }

    public class Test
    {
        public static bool[] TestIntegerBreak()
        {
            int result1 = LeetCode.IntegerBreak.Solution.IntegerBreak(2);
            int result2 = LeetCode.IntegerBreak.Solution.IntegerBreak(10);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 36)
            };
            return results;
        }
    }
}