// Smallest Even Multiple


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SmallestEvenMultiple
{
    public class Solution
    {
        public static int SmallestEvenMultiple(int n)
        {
            return n % 2 == 0 ? n : n * 2;  
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SmallestEvenMultiple(5), 10),
                ResultTester.CheckResult<int>(Solution.SmallestEvenMultiple(5), 10),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2413");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}