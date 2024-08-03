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
                ResultTester.CheckResult<string>(Solution.CustomSortString("cba", "abcd"), "dcba"),
                ResultTester.CheckResult<string>(Solution.CustomSortString("bcafg", "abcd"), "dbca"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Custom Sort String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}