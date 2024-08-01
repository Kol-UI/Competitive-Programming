// Find the Maximum Achievable Number



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheMaximumAchievableNumber
{
    public class Solution
    {
        public static int TheMaximumAchievableX(int num, int t)
        {
            return num + 2 * t;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.TheMaximumAchievableX(4, 1), 6),
                ResultTester.CheckResult<int>(Solution.TheMaximumAchievableX(3, 2), 7),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Maximum Achievable Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}