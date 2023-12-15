// Constrained Subsequence Sum

/*
Given an integer array nums and an integer k, return the maximum sum of a non-empty subsequence of that array such that for every two consecutive integers in the subsequence, nums[i] and nums[j], where i < j, the condition j - i <= k is satisfied.

A subsequence of an array is obtained by deleting some number of elements (can be zero) from the array, leaving the remaining elements in their original order.

 

Example 1:

Input: nums = [10,2,-10,5,20], k = 2
Output: 37
Explanation: The subsequence is [10, 2, 5, 20].

Example 2:

Input: nums = [-1,-2,-3], k = 1
Output: -1
Explanation: The subsequence must be non-empty, so we choose the largest number.

Example 3:

Input: nums = [10,-2,-10,-5,20], k = 2
Output: 23
Explanation: The subsequence is [10, -2, -5, 20].
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConstrainedSubsequenceSum
{
    public class Solution
    {
        public static int ConstrainedSubsetSum(int[] nums, int k)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            int maxSum = nums[0];
            var deque = new LinkedList<int>();

            dp[0] = nums[0];
            deque.AddLast(0);

            for (int i = 1; i < n; i++)
            {
                while (deque.First != null && i - deque.First.Value > k)
                {
                    deque.RemoveFirst();
                }

                dp[i] = Math.Max(0, dp[deque.First!.Value]) + nums[i];
                
                while (deque.Last != null && dp[i] >= dp[deque.Last.Value])
                {
                    deque.RemoveLast();
                }
                
                deque.AddLast(i);

                maxSum = Math.Max(maxSum, dp[i]);
            }

            return maxSum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int [] nums1 = {10,2,-10,5,20};
            int k1 = 2;
            int [] nums2 = {-1,-2,-3};
            int k2 = 1;
            int [] nums3 = {10,-2,-10,-5,20};
            int k3 = 2;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.ConstrainedSubsetSum(nums1, k1), 37),
                ResultTester.CheckResult<int>(Solution.ConstrainedSubsetSum(nums2, k2), -1),
                ResultTester.CheckResult<int>(Solution.ConstrainedSubsetSum(nums3, k3), 23),
            };
            return results;
        }
    }
}