// Count Distinct Numbers on Board


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountDistinctNumbersonBoard
{
    public class Solution
    {
        public static int DistinctIntegers(int n) => n == 1 ? 1 : n - 1;
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DistinctIntegers(5), 4),
                ResultTester.CheckResult<int>(Solution.DistinctIntegers(3), 2),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2549");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}