// Power of Two

/*
Given an integer n, return true if it is a power of two. Otherwise, return false.

An integer n is a power of two, if there exists an integer x such that n == 2x.

 

Example 1:

Input: n = 1
Output: true
Explanation: 20 = 1

Example 2:

Input: n = 16
Output: true
Explanation: 24 = 16

Example 3:

Input: n = 3
Output: false
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PowerofTwo
{
    public class Solution
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
                return false;
            
            return ((n & (n-1)) == 0);
        }
    }

    public class Test
    {
        public static bool[] TestPowerofTwo()
        {
            int case1_231 = 1;
            int case2_231 = 16;
            int case3_231 = 3;
            bool output1_231 = true;
            bool output2_231 = true;
            bool output3_231 = false;

            bool result1 = Solution.IsPowerOfTwo(case1_231);
            bool result2 = Solution.IsPowerOfTwo(case2_231);
            bool result3 = Solution.IsPowerOfTwo(case3_231);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, output1_231),
                ResultTester.CheckResult<bool>(result2, output2_231),
                ResultTester.CheckResult<bool>(result3, output3_231)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Power of Two");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestPowerofTwo());
        }
    }
}