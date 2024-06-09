// Breaking the Records


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.BreakingtheRecords
{
    public class Solution
    {
        //public static List<int> breakingRecords(List<int> scores)
        public static List<int> BreakingRecords(List<int> scores)
        {
            int minScore = scores[0];
            int maxScore = scores[0];
            int minRecordCount = 0;
            int maxRecordCount = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    minRecordCount++;
                }
                else if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    maxRecordCount++;
                }
            }

            List<int> result = new List<int> { maxRecordCount, minRecordCount };
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<List<int>>(Solution.BreakingRecords(new List<int>(){10, 5, 20, 20, 4, 5, 2, 25, 1}), new List<int>(){2, 4}),
                ResultTester.CheckResult<List<int>>(Solution.BreakingRecords(new List<int>(){3, 4, 21, 36, 10, 28, 35, 5, 24, 42}), new List<int>(){4, 0}),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Breaking the Records");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerRank, ProblemCategory.EasyHR, Test.TestCases());
        }
    }
}