// Sum of Digits in Base K


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofDigitsinBaseK
{
    public class Solution
    {
        public static int SumBase(int n, int k)
        {
            var result = 0;

            while (n > 0)
            {
                result += n % k;
                n /= k;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SumBase(34, 6), 9),
                ResultTester.CheckResult<int>(Solution.SumBase(10, 10), 1),
            };
            return results;
        }
    }
}