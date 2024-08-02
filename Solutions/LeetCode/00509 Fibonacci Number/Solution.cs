// Fibonacci Number

/*
The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,

F(0) = 0, F(1) = 1
F(n) = F(n - 1) + F(n - 2), for n > 1.
Given n, calculate F(n).

 

Example 1:

Input: n = 2
Output: 1
Explanation: F(2) = F(1) + F(0) = 1 + 0 = 1.

Example 2:

Input: n = 3
Output: 2
Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2.

Example 3:

Input: n = 4
Output: 3
Explanation: F(4) = F(3) + F(2) = 2 + 1 = 3.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FibonacciNumber
{
    public class Solution
    {
        public static int Fib(int n)
        {
            return n <= 1 ? n : Fib(n-1) + Fib(n-2);
        }
    }

    public class Test
    {
        public static bool[] TestFibonacciNumber()
        {
            int result1 = Solution.Fib(2);
            int result2 = Solution.Fib(3);
            int result3 = Solution.Fib(4);
            int output1_509 = 1;
            int output2_509 = 2;
            int output3_509 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_509),
                ResultTester.CheckResult<int>(result2, output2_509),
                ResultTester.CheckResult<int>(result3, output3_509)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Fibonacci Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestFibonacciNumber());
        }
    }
}