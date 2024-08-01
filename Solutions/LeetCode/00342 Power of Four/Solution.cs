// Power of Four

/*
Given an integer n, return true if it is a power of four. Otherwise, return false.

An integer n is a power of four, if there exists an integer x such that n == 4x.

 

Example 1:

Input: n = 16
Output: true

Example 2:

Input: n = 5
Output: false

Example 3:

Input: n = 1
Output: true
*/


using System;
using System.Numerics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PowerofFour
{
    public class Solution 
    {
        public static bool IsPowerOfFour(int n)
        {
            if (n > 0)
            {
                var units = BitOperations.PopCount((uint)n);
                var zeros = BitOperations.TrailingZeroCount((uint)n);
                return  units == 1 && zeros % 2 == 0;
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsPowerOfFour(16), true),
                ResultTester.CheckResult<bool>(Solution.IsPowerOfFour(5), false),
                ResultTester.CheckResult<bool>(Solution.IsPowerOfFour(1), true),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Four");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}