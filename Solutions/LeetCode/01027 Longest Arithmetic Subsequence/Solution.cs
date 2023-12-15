// Longest Arithmetic Subsequence

/*
Given an array nums of integers, return the length of the longest arithmetic subsequence in nums.

Note that:

A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.
A sequence seq is arithmetic if seq[i + 1] - seq[i] are all the same value (for 0 <= i < seq.length - 1).
 

Example 1:

Input: nums = [3,6,9,12]
Output: 4
Explanation:  The whole array is an arithmetic sequence with steps of length = 3.

Example 2:

Input: nums = [9,4,7,2,10]
Output: 3
Explanation:  The longest arithmetic subsequence is [4,7,10].

Example 3:

Input: nums = [20,1,15,3,10,5,8]
Output: 4
Explanation:  The longest arithmetic subsequence is [20,15,10,5].
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestArithmeticSubsequence
{
    public class Solution
    {
        public static int LongestArithSeqLength(int[] nums)
        {
            int maxCount = 2;
            int end = 0;
            var dp = new Dictionary<(int, int), int>();

            while (end < nums.Length)
            {
                int start = 0;
                while (start < end)
                {

                    int diff = nums[end] - nums[start];
                    int val = dp.ContainsKey((start, diff)) ? dp[(start, diff)] : 2;
                    dp[(end, diff)] = val + 1;

                    maxCount = Math.Max(maxCount, val);

                    start++;
                }

                end++;
            }

            return maxCount;

        }
    }

    public class Test
    {
        public static bool[] TestLongestArithmeticSubsequence()
        {
            int[] nums1 = {3,6,9,12};
            int[] nums2 = {9,4,7,2,10};
            int[] nums3 = {20,1,15,3,10,5,8};

            int result1 = LeetCode.LongestArithmeticSubsequence.Solution.LongestArithSeqLength(nums1);
            int result2 = LeetCode.LongestArithmeticSubsequence.Solution.LongestArithSeqLength(nums2);
            int result3 = LeetCode.LongestArithmeticSubsequence.Solution.LongestArithSeqLength(nums3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 3),
                ResultTester.CheckResult<int>(result3, 4)
            };

            return results;
        }
    }
}