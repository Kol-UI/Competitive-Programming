// Sqrt(x)

/*
Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

You must not use any built-in exponent function or operator.

For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
 

Example 1:

Input: x = 4
Output: 2
Explanation: The square root of 4 is 2, so we return 2.

Example 2:

Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Sqrtx
{
    public class Solution
    {
        public static int MySqrt(int x)
        {
            if (x == 0) return 0;

            int left = 1;
            int right = x;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int sqrt = x / mid;

                if (sqrt == mid) return mid;
                else if (sqrt < mid) right = mid - 1;
                else left = mid + 1;
            }

            return right;
        }
    }

    public class Test
    {
        public static bool[] TestSqrtx()
        {
            int case1 = 4;
            int case2 = 8;

            int result1 = Solution.MySqrt(case1);
            int result2 = Solution.MySqrt(case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, 2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sqrt(x)");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestSqrtx());
        }
    }
}