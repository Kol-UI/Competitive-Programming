// Left and Right Sum Differences


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LeftandRightSumDifferences
{
    public class Solution
    {
        public static int[] LeftRightDifference(int[] nums)
        {
            int leftSum = 0, rightSum = 0, n = nums.Length;

            foreach(int num in nums) rightSum += num;

            for(int i = 0; i < n; i++)
            {
                int val = nums[i];
                rightSum -= val;
                nums[i] = Math.Abs(leftSum - rightSum);
                leftSum += val;
            }

            return nums;  
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.LeftRightDifference(new int[]{10,4,8,3}), new int[]{15,1,11,22}),
                ResultTester.CheckResult<int[]>(Solution.LeftRightDifference(new int[]{1}), new int[]{0}),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2574");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}