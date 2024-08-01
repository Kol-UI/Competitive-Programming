// Pow(x, n)

/*
Implement pow(x, n), which calculates x raised to the power n (i.e., xn).

Example 1:

Input: x = 2.00000, n = 10
Output: 1024.00000

Example 2:

Input: x = 2.10000, n = 3
Output: 9.26100

Example 3:

Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Powxn
{
    public class Solution
    {
        public static double MyPow(double x, int n)
        {
            return Math.Pow(x, n);
        }
    }

    public class Test
    {
        public static bool[] TestPowxn()
        {
            int[] nums1 = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            int[] nums2 = new int[] {1};
            int[] nums3 = new int[] {5, 4, -1, 7, 8};

            // Case 1
            double x1 = 2.00000;
            int n1 = 10;
            double result1 = Solution.MyPow(x1,n1);

            // Case 2
            double x2 = 2.10000;
            int n2 = 3;
            double result2 = Solution.MyPow(x2,n2);

            // Case 3
            double x3 = 2.00000;
            int n3 = -2;
            double result3 = Solution.MyPow(x3,n3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1, 1024.00000),
                ResultTester.CheckResult<double>(result2, 9.261000000000001),
                ResultTester.CheckResult<double>(result3, 0.25000)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pow(x, n)");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestPowxn());
        }
    }
}