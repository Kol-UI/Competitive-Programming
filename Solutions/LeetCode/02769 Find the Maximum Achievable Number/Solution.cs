// Find the Maximum Achievable Number



using System;
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
}