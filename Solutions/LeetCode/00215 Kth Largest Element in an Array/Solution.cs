// Kth Largest Element in an Array

/*
Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

You must solve it in O(n) time complexity.

 

Example 1:

Input: nums = [3,2,1,5,6,4], k = 2
Output: 5

Example 2:

Input: nums = [3,2,3,1,2,4,5,5,6], k = 4
Output: 4
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KthLargestElementinanArray
{
    public class Solution
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums);
            return nums[nums.Length - k];
        }
    }

    public class Test
    {
        public static bool[] TestKthLargestElementinanArray()
        {
            int[] nums1 = {3,2,1,5,6,4};
            int k1 = 2;

            int[] nums2 = {3,2,3,1,2,4,5,5,6};
            int k2 = 4;

            int result1 = Solution.FindKthLargest(nums1, k1);
            int result2 = Solution.FindKthLargest(nums2, k2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 5),
                ResultTester.CheckResult<int>(result2, 4)
            };
            return results;
        }
    }
}