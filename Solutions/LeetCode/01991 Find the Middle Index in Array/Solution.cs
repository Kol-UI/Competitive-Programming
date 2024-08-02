// Find the Middle Index in Array

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheMiddleIndexinArray
{
    public class Solution
    {
        public static int FindMiddleIndex(int[] nums)
        {
            int prefix_sum = 0;
            int nums_sum = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                if (prefix_sum == nums_sum - prefix_sum - nums[i])
                    return i;
                prefix_sum += nums[i];
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindMiddleIndex(new int[]{2,3,-1,8,4}), 3),
                ResultTester.CheckResult<int>(Solution.FindMiddleIndex(new int[]{1,-1,4}), 2),
                ResultTester.CheckResult<int>(Solution.FindMiddleIndex(new int[]{2,5}), -1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1991");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}