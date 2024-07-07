// Water Bottles

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.WaterBottles
{
    public class Solution
    {
        public static int NumWaterBottles(int numBottles, int numExchange)
        {
            int result = 0;
            int rem = 0;
            while(numBottles != 0)
            {
                result += numBottles;

                numBottles += rem;
                rem = numBottles % numExchange;
                numBottles = numBottles / numExchange;
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
                ResultTester.CheckResult<int>(Solution.NumWaterBottles(9, 3), 13),
                ResultTester.CheckResult<int>(Solution.NumWaterBottles(15, 4), 19)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Water Bottles");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}