// Longest Arithmetic Subsequence of Given Difference

/*
Given an integer array arr and an integer difference, return the length of the longest subsequence in arr which is an arithmetic sequence such that the difference between adjacent elements in the subsequence equals difference.

A subsequence is a sequence that can be derived from arr by deleting some or no elements without changing the order of the remaining elements.

 

Example 1:

Input: arr = [1,2,3,4], difference = 1
Output: 4
Explanation: The longest arithmetic subsequence is [1,2,3,4].

Example 2:

Input: arr = [1,3,5,7], difference = 1
Output: 1
Explanation: The longest arithmetic subsequence is any single element.

Example 3:

Input: arr = [1,5,7,8,5,3,4,2,1], difference = -2
Output: 4
Explanation: The longest arithmetic subsequence is [7,5,3,1].
*/

using System;
namespace CompetitiveProgramming.LeetCode.LongestArithmeticSubsequenceofGivenDifference
{
    public class Solution
    {
        public static int LongestSubsequence(int[] arr, int difference)
        {
            Dictionary<int, int> elementPos = new Dictionary<int, int>();
            int n = arr.Length;
            int[] dp = new int[n];
            Array.Fill(dp, 1);
            int res = 1;

            for(int i = 0; i < n; i++)
            {
                int current = arr[i];
                int prev = current - difference;
                
                if(elementPos.ContainsKey(prev))
                {
                    int prevElementIdx = elementPos[prev];
                    dp[i] = dp[prevElementIdx] + 1;
                }

                if(elementPos.ContainsKey(arr[i]))
                {
                    elementPos[current] = i;
                }
                else
                {
                    elementPos.Add(current, i);
                }

                res = Math.Max(res, dp[i]);
            }

            return res;
        }
    }
}