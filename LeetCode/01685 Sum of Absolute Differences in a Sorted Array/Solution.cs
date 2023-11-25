// Sum of Absolute Differences in a Sorted Array

/*
You are given an integer array nums sorted in non-decreasing order.

Build and return an integer array result with the same length as nums such that result[i] is equal to the summation of absolute differences between nums[i] and all the other elements in the array.

In other words, result[i] is equal to sum(|nums[i]-nums[j]|) where 0 <= j < nums.length and j != i (0-indexed).

 

Example 1:

Input: nums = [2,3,5]
Output: [4,3,5]
Explanation: Assuming the arrays are 0-indexed, then
result[0] = |2-2| + |2-3| + |2-5| = 0 + 1 + 3 = 4,
result[1] = |3-2| + |3-3| + |3-5| = 1 + 0 + 2 = 3,
result[2] = |5-2| + |5-3| + |5-5| = 3 + 2 + 0 = 5.

Example 2:

Input: nums = [1,4,6,8,10]
Output: [24,15,13,15,21]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofAbsoluteDifferencesinaSortedArray
{
    public class Solution
    {
        public static int[] GetSumAbsoluteDifferences(int[] nums)
        {
            int prefix = 0, suffix = 0, n = nums.Length;
            int[] result = new int[n];
            int[] prefixSums = new int[n];

            for (int i = 0; i < n; i++)
            {
                prefixSums[i] = (i == 0) ? nums[0] : prefixSums[i - 1] + nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                prefix = (i == 0) ? 0 : nums[i] * i - prefixSums[i - 1];
                suffix = (i == n - 1) ? 0 : prefixSums[n - 1] - prefixSums[i] - (nums[i] * (n - i - 1));
                result[i] = prefix + suffix;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {2,3,5};
            int[] nums2 = {1,4,6,8,10};

            int[] expected1 = {4,3,5};
            int[] expected2 = {24,15,13,15,21};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.GetSumAbsoluteDifferences(nums1), expected1),
                ResultTester.CheckResult<int[]>(Solution.GetSumAbsoluteDifferences(nums2), expected2),
            };
            return results;
        }
    }
}