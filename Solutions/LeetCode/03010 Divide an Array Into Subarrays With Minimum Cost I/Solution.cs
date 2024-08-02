// Divide an Array Into Subarrays With Minimum Cost I


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.DivideanArrayIntoSubarraysWithMinimumCostI
{
    public class Solution
    {
        public static int MinimumCost(int[] nums)
        {
            var result = nums[0];
            var min0 = Math.Min(nums[1], nums[2]);
            var min1 = Math.Max(nums[1], nums[2]);

            for (int i = 3; i < nums.Length; i++)
            {
                if (nums[i] <= min0)
                {
                    min1 = min0;
                    min0 = nums[i];
                    continue;
                }
                if (nums[i] < min1)
                {
                    min1 = nums[i];
                    continue;
                }
            }
            return result + min0 + min1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumCost(new int[]{1,2,3,12}), 6),
                ResultTester.CheckResult<int>(Solution.MinimumCost(new int[]{5,4,3}), 12),
                ResultTester.CheckResult<int>(Solution.MinimumCost(new int[]{10,3,1,1}), 12),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("3010");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}