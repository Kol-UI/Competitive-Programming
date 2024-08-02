// Count Ways To Build Good Strings

/*
Given the integers zero, one, low, and high, we can construct a string by starting with an empty string, and then at each step perform either of the following:

Append the character '0' zero times.
Append the character '1' one times.
This can be performed any number of times.

A good string is a string constructed by the above process having a length between low and high (inclusive).

Return the number of different good strings that can be constructed satisfying these properties. Since the answer can be large, return it modulo 109 + 7.


Example 1:

Input: low = 3, high = 3, zero = 1, one = 1
Output: 8
Explanation: 
One possible valid good string is "011". 
It can be constructed as follows: "" -> "0" -> "01" -> "011". 
All binary strings from "000" to "111" are good strings in this example.

Example 2:

Input: low = 2, high = 3, zero = 1, one = 2
Output: 5
Explanation: The good strings are "00", "11", "000", "110", and "011".
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountWaysToBuildGoodStrings
{
    public class Solution
    {
        static Dictionary<int,int> dp = new();
        static int mod = 1_000_000_007;

        public static int CountGoodStrings(int low, int high, int zero, int one) 
        {
            return Helper(0, low, high, zero, one);
        }

        private static int Helper(int length, int low, int high, int zero, int one)
        {
            if (length > high) return 0;

            if(dp.ContainsKey(length)) return dp[length];

            var temp = length >= low ? 1 : 0;
            dp[length] = (temp + Helper(length + zero, low, high, zero, one) + Helper(length + one, low, high, zero, one)) % mod;

            return dp[length];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int low1 = 3;
            int high1 = 3;
            int zero1 = 1;
            int one1 = 1;

            int result1 = Solution.CountGoodStrings(low1, high1, zero1, one1);

            int low2 = 2;
            int high2 = 3;
            int zero2 = 1;
            int one2 = 2;

            int result2 = Solution.CountGoodStrings(low2, high2, zero2, one2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 8),
                ResultTester.CheckResult<int>(result2, 8)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Count Ways To Build Good Strings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}