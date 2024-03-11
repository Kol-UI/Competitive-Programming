// Custom Sort String


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CustomSortString
{
    public class Solution
    {
        public static string CustomSortString(string order, string s) => string.Concat(s.OrderBy(order.IndexOf));
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.CustomSortString("cba", "abcd"), "cbad"),
                ResultTester.CheckResult<string>(Solution.CustomSortString("bcafg", "abcd"), "bcad"),
            };
            return results;
        }
    }
}