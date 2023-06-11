// Longest Increasing Subsequence

/*
Given an integer array nums, return the length of the longest strictly increasing 
subsequence
.

 

Example 1:

Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.

Example 2:

Input: nums = [0,1,0,3,2,3]
Output: 4

Example 3:

Input: nums = [7,7,7,7,7,7,7]
Output: 1
*/

using System;
namespace CompetitiveProgramming.LeetCode.LongestIncreasingSubsequence
{
    public class Solution
    {
        public static int LengthOfLIS(int[] nums)
        {
            int n = nums.Length;
            int[][] dp = new int[n][];
            for(int i = 0; i < n; i++)
            {
                dp[i] = new int[n + 1];
                Array.Fill(dp[i], -1);
            } 

            int solve(int i, int lastTakenIndex)
            {
                if(i >= n) return 0;

                if(dp[i][lastTakenIndex] != -1) return dp[i][lastTakenIndex];

                int op1 = solve(i+1,lastTakenIndex);
                int op2 = (lastTakenIndex == n || nums[i] > nums[lastTakenIndex]) ? solve(i+1,i) + 1 : 0;

                return dp[i][lastTakenIndex] = Math.Max(op1,op2);
            }

            return solve(0,n);
        }
    }
}