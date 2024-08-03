// Sum of Square Numbers

/*
Given a non-negative integer c, decide whether there're two integers a and b such that a2 + b2 = c.

 

Example 1:

Input: c = 5
Output: true
Explanation: 1 * 1 + 2 * 2 = 5

Example 2:

Input: c = 3
Output: false
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofSquareNumbers
{
    public class Solution
    {
        public static bool JudgeSquareSum(int c)
        {
            var lo = 0L;
            var hi = (long)Math.Sqrt(c);

            while (lo <= hi)
            {
                var sum = lo * lo + hi * hi;
                if (sum == c)
                {
                    return true;
                }

                if (sum > c)
                {
                    --hi;
                }
                else
                {
                    ++lo;
                }
            }
            
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestSumofSquareNumbers()
        {
            int c1 = 5;
            int c2 = 3;

            bool result1 = Solution.JudgeSquareSum(c1);
            bool result2 = Solution.JudgeSquareSum(c2);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sum of Square Numbers");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSumofSquareNumbers());
        }
    }
}