// Max Dot Product of Two Subsequences

/*
Given two arrays nums1 and nums2.

Return the maximum dot product between non-empty subsequences of nums1 and nums2 with the same length.

A subsequence of a array is a new array which is formed from the original array by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, [2,3,5] is a subsequence of [1,2,3,4,5] while [1,5,3] is not).

 

Example 1:

Input: nums1 = [2,1,-2,5], nums2 = [3,0,-6]
Output: 18
Explanation: Take subsequence [2,-2] from nums1 and subsequence [3,-6] from nums2.
Their dot product is (2*3 + (-2)*(-6)) = 18.

Example 2:

Input: nums1 = [3,-2], nums2 = [2,-6,7]
Output: 21
Explanation: Take subsequence [3] from nums1 and subsequence [7] from nums2.
Their dot product is (3*7) = 21.

Example 3:

Input: nums1 = [-1,-1], nums2 = [1,1]
Output: -1
Explanation: Take subsequence [-1] from nums1 and subsequence [1] from nums2.
Their dot product is -1.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaxDotProductofTwoSubsequences
{
    public class Solution
    {
        public static int MaxDotProduct(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int m = nums2.Length;
            
            int[,] dp = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dp[i, j] = nums1[i] * nums2[j];
                    if (i > 0 && j > 0)
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - 1] + nums1[i] * nums2[j]);
                    if (i > 0)
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j]);
                    if (j > 0)
                        dp[i, j] = Math.Max(dp[i, j], dp[i, j - 1]);
                }
            }
            
            return dp[n - 1, m - 1];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_1 = {2,1,-2,5};
            int[] nums2_1 = {3,0,-6};
            int[] nums1_2 = {3,-2};
            int[] nums2_2 = {2,-6,7};
            int[] nums1_3 = {-1,-1};
            int[] nums2_3 = {1,1};
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxDotProduct(nums1_1, nums2_1), 18),
                ResultTester.CheckResult<int>(Solution.MaxDotProduct(nums1_2, nums2_2), 21),
                ResultTester.CheckResult<int>(Solution.MaxDotProduct(nums1_3, nums2_3), -1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Max Dot Product of Two Subsequences");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}