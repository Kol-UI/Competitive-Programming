// Calculate Money in Leetcode Bank



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CalculateMoneyinLeetcodeBank
{
    public class Solution
    {
        public static int TotalMoney(int n)
        {
            int counter = 0;
            int week = 0;
            int rate = 1;

            for (int i = 1; i <= n; i++)
            {
                counter += rate++ + week;

                if (i % 7 == 0)
                {
                    week++;
                    rate = 1;
                }
            }

            return counter;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.TotalMoney(4), 10),
                ResultTester.CheckResult<int>(Solution.TotalMoney(10), 37),
                ResultTester.CheckResult<int>(Solution.TotalMoney(20), 96),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1716");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}