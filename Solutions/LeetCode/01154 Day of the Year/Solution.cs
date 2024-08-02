// Day of the Year


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DayoftheYear
{
    public class Solution
    {
        public static int DayOfYear(string date)
        {
            DateTime dateTime = DateTime.Parse(date);
            int dayOfYear = dateTime.DayOfYear;
            return dayOfYear;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DayOfYear("2019-01-09"), 9),
                ResultTester.CheckResult<int>(Solution.DayOfYear("2019-02-10"), 41),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Day of the Year");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}