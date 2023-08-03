using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumSubarray
{
	public class Solution
	{
        // Given an integer array nums, find the subarray which has the largest sum and return its sum.

        //Example 1:
        //Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
        //Output: 6
        //Explanation: [4,-1,2,1] has the largest sum = 6.
        //Example 2:
        //Input: nums = [1]
        //Output: 1
        //Example 3:
        //Input: nums = [5, 4, -1, 7, 8]
        //Output: 23

        public static int MaxSubArray(int[] nums)
        {
            int bestSum = int.MinValue;
            int sum = 0;

            for (int i = 0, n = nums.Length; i < n; ++i)
            {
                sum = Math.Max(sum + nums[i], nums[i]);
                bestSum = Math.Max(bestSum, sum);
            }

            return bestSum;
        }
    }

    public class Test
    {
        public static bool[] TestMaximumSubarray()
        {
            int[] nums1 = new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4};
            int[] nums2 = new int[] {1};
            int[] nums3 = new int[] {5, 4, -1, 7, 8};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxSubArray(nums1), 6),
                ResultTester.CheckResult<int>(Solution.MaxSubArray(nums2), 1),
                ResultTester.CheckResult<int>(Solution.MaxSubArray(nums3), 23)
            };
            return results;
        }
    }
}

