// Maximum Length of Subarray With Positive Product

/*
Given an array of integers nums, find the maximum length of a subarray where the product of all its elements is positive.

A subarray of an array is a consecutive sequence of zero or more values taken out of that array.

Return the maximum length of a subarray with positive product.

 

Example 1:

Input: nums = [1,-2,-3,4]
Output: 4
Explanation: The array nums already has a positive product of 24.

Example 2:

Input: nums = [0,1,-2,-3,-4]
Output: 3
Explanation: The longest subarray with positive product is [1,-2,-3] which has a product of 6.
Notice that we cannot include 0 in the subarray since that'll make the product 0 which is not positive.

Example 3:

Input: nums = [-1,-2,-3,0,1]
Output: 2
Explanation: The longest subarray with positive product is [-1,-2] or [-2,-3].
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumLengthofSubarrayWithPositiveProduct
{
    public class Solution
    {
        public static int GetMaxLen(int[] nums)
        {
            var cm = Int32.MinValue;
            double p = 1;
            var cr = 0;

            foreach (var num in nums)
            {
                p *= num;
                cr++;

                if (num == 0)
                {
                    cr = 0;
                    p = 1;
                    continue;
                }

                if (p > 0 && cr > cm) cm = cr;
            }

            cr = 0;
            p = 1;

            foreach (var num in nums.Reverse())
            {
                p *= num;
                cr++;

                if (num == 0)
                {
                    cr = 0;
                    p = 1;
                    continue;
                }

                if (p > 0 && cr > cm) cm = cr;
            }
            
            return cm > 0 ? cm : 0;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_1567 = {1,-2,-3,4};
            int[] nums2_1567 = {0,1,-2,-3,-4};
            int[] nums3_1567 = {-1,-2,-3,0,1};

            int result1_1567 = Solution.GetMaxLen(nums1_1567);
            int result2_1567 = Solution.GetMaxLen(nums2_1567);
            int result3_1567 = Solution.GetMaxLen(nums3_1567);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1567, 4),
                ResultTester.CheckResult<int>(result2_1567, 3),
                ResultTester.CheckResult<int>(result3_1567, 2)
            };
            return results;
        }
    }
}