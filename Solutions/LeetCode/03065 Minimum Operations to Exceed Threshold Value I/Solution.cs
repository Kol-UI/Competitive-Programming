// Minimum Operations to Exceed Threshold Value I


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumOperationstoExceedThresholdValueI
{
    public class Solution
    {
        public static int MinOperations(int[] nums, int k)
        {
            return nums.Count(num => num < k);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations(new int[]{2,11,10,1,3}, 10), 3),
                ResultTester.CheckResult<int>(Solution.MinOperations(new int[]{1,1,2,4,9}, 1), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Operations to Exceed Threshold Value I");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}