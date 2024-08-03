// Ugly Number III

/*
An ugly number is a positive integer that is divisible by a, b, or c.

Given four integers n, a, b, and c, return the nth ugly number.

 

Example 1:

Input: n = 3, a = 2, b = 3, c = 5
Output: 4
Explanation: The ugly numbers are 2, 3, 4, 5, 6, 8, 9, 10... The 3rd is 4.

Example 2:

Input: n = 4, a = 2, b = 3, c = 4
Output: 6
Explanation: The ugly numbers are 2, 3, 4, 6, 8, 9, 10, 12... The 4th is 6.

Example 3:

Input: n = 5, a = 2, b = 11, c = 13
Output: 10
Explanation: The ugly numbers are 2, 4, 6, 8, 10, 11, 12, 13... The 5th is 10.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.UglyNumberIII
{
    public class Solution
    {
        readonly static int max_ans = 2000000000;

        public static int NthUglyNumber(int n, int a, int b, int c)
        {
            int l = 1;
            int r = max_ans;
            int result = 0;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (Count(mid, a, b, c) >= n)
                {
                    result = mid;
                    r = mid - 1;
                }
                else l = mid + 1;
            }
            return result;
        }

        public static int Count(long num, long a, long b, long c)
        {
            return (int)(num / a + num / b + num / c
                - num / Lcm(a, b) - num / Lcm(b, c)
                - num / Lcm(a, c) + num / (Lcm(a,Lcm(b, c))));
        }

        public static long Gcd(long a, long b)
        {
            if (a == 0) return b;
            return Gcd(b % a, a);
        }

        public static long Lcm(long a, long b)
        {
            return a * b / Gcd(a, b);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NthUglyNumber(3, 2, 3, 5), 4),
                ResultTester.CheckResult<int>(Solution.NthUglyNumber(4, 2, 3, 4), 6),
                ResultTester.CheckResult<int>(Solution.NthUglyNumber(5, 2, 11, 13), 10),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ugly Number III");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}