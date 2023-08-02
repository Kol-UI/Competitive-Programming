// Ugly Number II

/*
An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

Given an integer n, return the nth ugly number.


Example 1:

Input: n = 10
Output: 12
Explanation: [1, 2, 3, 4, 5, 6, 8, 9, 10, 12] is the sequence of the first 10 ugly numbers.

Example 2:

Input: n = 1
Output: 1
Explanation: 1 has no prime factors, therefore all of its prime factors are limited to 2, 3, and 5.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.UglyNumberII
{
    public class Solution
    {
        public static int NthUglyNumber(int n)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 8, 9, 10, 12 };
            if (n <= 10) return list[n - 1];
            for (int i = 11; i <= n; i++)
            {
                var next = GetNext(list);
                list.Add(next);
            }
            return list[list.Count - 1];
        }
        
        private static int GetNext(List<int> list)
        {
            var last = list[list.Count - 1];
            var min2 = (long)(2 * list.Where(p => (long)p * 2 > last).Min());
            var min3 = (long)(3 * list.Where(p => (long)p * 3 > last).Min());
            var min5 = (long)(5 * list.Where(p => (long)p * 5 > last).Min());
            return (int)Math.Min(Math.Min(min2, min3), min5);
        }
    }

    public class Test
    {
        public static bool[] TestUglyNumberII()
        {
            int result1 = Solution.NthUglyNumber(10);
            int result2 = Solution.NthUglyNumber(1);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 12),
                ResultTester.CheckResult<int>(result2, 1)
            };
            return results;
        }
    }
}
