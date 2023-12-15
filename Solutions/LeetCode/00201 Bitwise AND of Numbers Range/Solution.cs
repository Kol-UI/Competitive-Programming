// Bitwise AND of Numbers Range

/*
Given two integers left and right that represent the range [left, right], return the bitwise AND of all numbers in this range, inclusive.

Example 1:

Input: left = 5, right = 7
Output: 4

Example 2:

Input: left = 0, right = 0
Output: 0

Example 3:

Input: left = 1, right = 2147483647
Output: 0
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BitwiseANDofNumbersRange
{
    public class Solution
    {
        public static int RangeBitwiseAnd(int left, int right)
        {
            while (right > left) right &= right - 1;
            return left & right;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.RangeBitwiseAnd(5, 7), 4),
                ResultTester.CheckResult<int>(Solution.RangeBitwiseAnd(0, 0), 0),
                ResultTester.CheckResult<int>(Solution.RangeBitwiseAnd(1, 2147483647), 0),
            };
            return results;
        }
    }
}