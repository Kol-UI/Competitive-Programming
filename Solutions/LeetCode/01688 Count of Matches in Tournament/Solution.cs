// Count of Matches in Tournament




using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountofMatchesinTournament
{
    public class Solution
    {
        public static int NumberOfMatches(int n)
        {
            int count = 0;
            while(n != 1)
            {
                if(n % 2 == 0)
                {
                    count += n / 2;
                    n = n / 2;
                }
                else
                {
                    count += (n - 1) / 2;
                    n = (n - 1 ) / 2 + 1;
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
                ResultTester.CheckResult<int>(Solution.NumberOfMatches(7), 6),
                ResultTester.CheckResult<int>(Solution.NumberOfMatches(14), 13),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1688");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}