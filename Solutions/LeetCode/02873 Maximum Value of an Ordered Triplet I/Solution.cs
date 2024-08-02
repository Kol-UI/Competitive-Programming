// Maximum Value of an Ordered Triplet I



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumValueofanOrderedTripletI
{
    public class Solution
    {
        public static long MaximumTripletValue(int[] nums)
        {
            long result = 0;
            long maxDiff = nums[0] - nums[1];
            long max = Math.Max(nums[0],nums[1]);

            for(int i = 2; i < nums.Length; i++)
            {
                long tempo = maxDiff * nums[i];
                result = Math.Max(result, tempo);
                maxDiff = Math.Max(maxDiff, max - nums[i]);
                max = Math.Max(max, nums[i]);
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {12,6,1,2,7};
            int[] nums2 = {1,10,3,4,19};
            int[] nums3 = {1,2,3};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.MaximumTripletValue(nums1), 77),
                ResultTester.CheckResult<long>(Solution.MaximumTripletValue(nums2), 133),
                ResultTester.CheckResult<long>(Solution.MaximumTripletValue(nums3), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2873");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}