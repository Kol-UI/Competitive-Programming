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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestLongestIncreasingSubsequence()
        {
            int[] nums1_300 = {10,9,2,5,3,7,101,18};
            int[] nums2_300 = {0,1,0,3,2,3};
            int[] nums3_300 = {7,7,7,7,7,7,7};

            int result1_300 = Solution.LengthOfLIS(nums1_300);
            int result2_300 = Solution.LengthOfLIS(nums2_300);
            int result3_300 = Solution.LengthOfLIS(nums3_300);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_300, 4),
                ResultTester.CheckResult<int>(result2_300, 4),
                ResultTester.CheckResult<int>(result3_300, 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Increasing Subsequence");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestLongestIncreasingSubsequence());
        }
    }
}