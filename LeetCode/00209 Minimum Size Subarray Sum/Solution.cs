// Minimum Size Subarray Sum

/*
Given an array of positive integers nums and a positive integer target, return the minimal length of a 
subarray
 whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.

 

Example 1:

Input: target = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.

Example 2:

Input: target = 4, nums = [1,4,4]
Output: 1

Example 3:

Input: target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0
*/

using System;
namespace CompetitiveProgramming.LeetCode.MinimumSizeSubarraySum
{
    public class Solution 
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int n = nums.Length;
            int result = int.MaxValue;
            int left = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
                while (sum >= target)
                {
                    result = Math.Min(result, i + 1 - left);
                    sum -= nums[left++];
                }
            }
            return (result != int.MaxValue) ? result : 0;
        }
    }
}