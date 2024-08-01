using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AddTwoIntegers
{
    public class Solution
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int Case1_2235 = Solution.Sum(12, 5);

            // Case 2
            int Case2_2235 = Solution.Sum(-10, 4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_2235, 17),
                ResultTester.CheckResult<int>(Case2_2235, -6)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Aadd Two Integers");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}

