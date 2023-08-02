// Majority Element

/*
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3

Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MajorityElement
{
    public class Solution
    {
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }
    }

    public class Test
    {
        public static bool[] TestMajorityElement()
        {
            int[] nums1 = {3,2,3};
            int[] nums2 = {2,2,1,1,1,2,2};

            int result1 = Solution.MajorityElement(nums1);
            int result2 = Solution.MajorityElement(nums2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2)
            };
            return results;
        }
    }
}
