// Height Checker

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.HeightChecker
{
    public class Solution 
    {
        public static int HeightChecker(int[] heights) 
        {
            return heights.OrderBy(x => x)
                .Select((s, i) => heights[i] == s ? 0 : 1)
                .Sum();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.HeightChecker(new int[]{1,1,4,2,1,3}), 3),
                ResultTester.CheckResult<int>(Solution.HeightChecker(new int[]{5,1,2,3,4}), 5),
                ResultTester.CheckResult<int>(Solution.HeightChecker(new int[]{1,2,3,4,5}), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Height Checker");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}