// Minimum Time to Make Rope Colorful



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumTimetoMakeRopeColorful
{
    public class Solution
    {
        public static int MinCost(string colors, int[] neededTime)
        {
            return Enumerable.Range(1, colors.Length - 1)
                .Where(i => colors[i] == colors[i - 1])
                .Sum(i =>
                {
                    var minTime = Math.Min(neededTime[i], neededTime[i - 1]);
                    neededTime[i] = Math.Max(neededTime[i], neededTime[i - 1]);

                    return minTime;
                });
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string colors1 = "abaac";
            int[] neededTime1 = {1,2,3,4,5};
            string colors2 = "abc";
            int[] neededTime2 = {1,2,3};
            string colors3 = "aabaa";
            int[] neededTime3 = {1,2,3,4,1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinCost(colors1, neededTime1), 3),
                ResultTester.CheckResult<int>(Solution.MinCost(colors2, neededTime2), 0),
                ResultTester.CheckResult<int>(Solution.MinCost(colors3, neededTime3), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Time to Make Rope Colorful");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}