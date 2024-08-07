// Maximum Ascending Subarray Sum

/*
Given an array of positive integers nums, return the maximum possible sum of an ascending subarray in nums.

A subarray is defined as a contiguous sequence of numbers in an array.

A subarray [numsl, numsl+1, ..., numsr-1, numsr] is ascending if for all i where l <= i < r, numsi  < numsi+1. Note that a subarray of size 1 is ascending.

 

Example 1:

Input: nums = [10,20,30,5,10,50]
Output: 65
Explanation: [5,10,50] is the ascending subarray with the maximum sum of 65.

Example 2:

Input: nums = [10,20,30,40,50]
Output: 150
Explanation: [10,20,30,40,50] is the ascending subarray with the maximum sum of 150.

Example 3:

Input: nums = [12,17,15,13,10,11,12]
Output: 33
Explanation: [10,11,12] is the ascending subarray with the maximum sum of 33.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumAscendingSubarraySum
{
    public class Solution
    {
        public static int MaxAscendingSum(int[] nums)
        {
            int min = nums[0]; 
            int max = min;

            for(int i = 1; i < nums.Length;i++)
            {
                if(nums[i] > nums[i-1])
                {
                    min += nums[i];
                }
                else 
                {
                    min = nums[i];
                }

                max = Math.Max(max,min);
                
            }

            return max;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {10,20,30,5,10,50};
            int[] nums2 = {10,20,30,40,50};
            int[] nums3 = {12,17,15,13,10,11,12};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxAscendingSum(nums1), 65),
                ResultTester.CheckResult<int>(Solution.MaxAscendingSum(nums2), 150),
                ResultTester.CheckResult<int>(Solution.MaxAscendingSum(nums3), 33)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1800");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}