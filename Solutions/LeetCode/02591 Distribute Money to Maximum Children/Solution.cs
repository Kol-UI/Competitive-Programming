// Distribute Money to Maximum Children


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DistributeMoneytoMaximumChildren
{
    public class Solution
    {
        public static int DistMoney(int money, int children)
        {
            if (money < children) return -1;

            money -= children;

            var (div, mod) = (money / 7, money % 7);

            if (div == children)
            {
                return mod == 0 ? children : children - 1;
            }

            if (div < children)
            {
                return mod == 3 && children - div == 1 ? div - 1 : div;
            }

            return children - 1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DistMoney(20, 3), 1),
                ResultTester.CheckResult<int>(Solution.DistMoney(16, 2), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2591");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}