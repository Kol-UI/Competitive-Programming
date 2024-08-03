// Subarray Product Less Than K

/*
Given an array of integers nums and an integer k, return the number of contiguous subarrays where the product of all the elements in the subarray is strictly less than k.

 

Example 1:

Input: nums = [10,5,2,6], k = 100
Output: 8
Explanation: The 8 subarrays that have product less than 100 are:
[10], [5], [2], [6], [10, 5], [5, 2], [2, 6], [5, 2, 6]
Note that [10, 5, 2] is not included as the product of 100 is not strictly less than k.


Example 2:

Input: nums = [1,2,3], k = 0
Output: 0
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SubarrayProductLessThanK
{
    public class Solution
    {
        public static int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int ret = 0;
            int prod = 1;
            int left = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                prod *= nums[i];

                while (prod >= k && left <= i)
                {
                    prod /= nums[left];
                    left++;
                }

                ret += 1 + i - left;
            }

            return ret;
        }
    }

    public class Test
    {
        public static bool[] TestSubarrayProductLessThanK()
        {
            int[] nums1 = {10,5,2,6}; int k1 = 100;
            int[] nums2 = {1,2,3}; int k2 = 0;
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumSubarrayProductLessThanK(nums1, k1), 8),
                ResultTester.CheckResult<int>(Solution.NumSubarrayProductLessThanK(nums2, k2), 0)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Subarray Produc Less Than K");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSubarrayProductLessThanK());
        }
    }
}