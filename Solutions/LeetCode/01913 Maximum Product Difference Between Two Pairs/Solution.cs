// Maximum Product Difference Between Two Pairs



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumProductDifferenceBetweenTwoPairs
{
    public class Solution
    {
        public static int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length - 1] * nums[nums.Length - 2] - nums[0] * nums[1];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {5,6,2,7,4};
            int[] nums2 = {4,2,5,9,7,4,8};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxProductDifference(nums1), 34),
                ResultTester.CheckResult<int>(Solution.MaxProductDifference(nums2), 64),
            };
            return results;
        }
    }
}