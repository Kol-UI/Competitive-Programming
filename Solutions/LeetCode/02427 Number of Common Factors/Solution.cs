// Number of Common Factors


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofCommonFactors
{
    public class Solution
    {
        public static int CommonFactors(int a, int b)
        {
            int value = 0;
            int count = 0;

            if (a < b)
            {
                value = a;
            }
            else 
            {
                value = b;
            }
            for (int i = 1; i <= value; i++)
            {
                if(a % i == 0 && b % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CommonFactors(12, 6), 4),
                ResultTester.CheckResult<int>(Solution.CommonFactors(25, 30), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Number of Common Factors");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}