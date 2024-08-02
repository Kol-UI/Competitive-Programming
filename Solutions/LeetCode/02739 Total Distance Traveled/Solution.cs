// Total Distance Traveled


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.TotalDistanceTraveled
{
    public class Solution
    {
        public static int DistanceTraveled(int mainTank, int additionalTank)
        {
            int currTank = mainTank;
            int totalFuelBurnt = 0;

            while(currTank >= 5 && additionalTank > 0)
            {
                currTank -= 4;
                --additionalTank;
                totalFuelBurnt += 5;
            }

            totalFuelBurnt += currTank;
            return totalFuelBurnt * 10;
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DistanceTraveled(5, 10), 60),
                ResultTester.CheckResult<int>(Solution.DistanceTraveled(1, 2), 10),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2739");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}