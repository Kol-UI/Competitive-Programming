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
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestLongestArithmeticSubsequenceofGivenDifference()
        {
            int[] arr1 = {1,2,3,4}; int difference1 = 1;
            int[] arr2 = {1,3,5,7}; int difference2 = 1;
            int[] arr3 = {1,5,7,8,5,3,4,2,1}; int difference3 = -2;
            int result1 = Solution.LongestSubsequence(arr1, difference1);
            int result2 = Solution.LongestSubsequence(arr2, difference2);
            int result3 = Solution.LongestSubsequence(arr3, difference3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 1),
                ResultTester.CheckResult<int>(result3, 4)
            };
            return results;
        }
    }
}