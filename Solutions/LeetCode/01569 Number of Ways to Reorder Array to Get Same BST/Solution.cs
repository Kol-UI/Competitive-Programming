// Number of Ways to Reorder Array to Get Same BST

/*
Given an array nums that represents a permutation of integers from 1 to n. We are going to construct a binary search tree (BST) by inserting the elements of nums in order into an initially empty BST. Find the number of different ways to reorder nums so that the constructed BST is identical to that formed from the original array nums.

For example, given nums = [2,1,3], we will have 2 as the root, 1 as a left child, and 3 as a right child. The array [2,3,1] also yields the same BST but [3,2,1] yields a different BST.
Return the number of ways to reorder nums such that the BST formed is identical to the original BST formed from nums.

Since the answer may be very large, return it modulo 109 + 7.

 

Example 1:


Input: nums = [2,1,3]
Output: 1
Explanation: We can reorder nums to be [2,3,1] which will yield the same BST. There are no other ways to reorder nums which will yield the same BST.


Example 2:


Input: nums = [3,4,5,1,2]
Output: 5
Explanation: The following 5 arrays will yield the same BST: 
[3,1,2,4,5]
[3,1,4,2,5]
[3,1,4,5,2]
[3,4,1,2,5]
[3,4,1,5,2]


Example 3:


Input: nums = [1,2,3]
Output: 0
Explanation: There are no other orderings of nums that will yield the same BST.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofWaystoReorderArraytoGetSameBST
{
    public class Solution
    {
        public static int MOD = (int)1e9+7;

        public static List<List<long>> GenerateComb(int n)
        {
            List<List<long>> dp = new List<List<long>>(n + 1);
            for (int i = 0; i <= n; i++)
            {
                dp.Add(new List<long>(new long[n + 1]));
            }

            for (int i = 0; i <= n; ++i)
            {
                dp[i][0] = dp[i][i] = 1;

                for (int j = 1; j < i; ++j)
                    dp[i][j] = (dp[i - 1][j - 1] + dp[i - 1][j]) % MOD;
            }

            return dp;
        }

        public static int CountBST(List<int> nums, List<List<long>> dp)
        {
            if (nums.Count <= 2)
                return 1;

            int root = nums[0];
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 1; i < nums.Count; ++i)
            {
                if (nums[i] < root)
                    left.Add(nums[i]);
                else
                    right.Add(nums[i]);
            }

            long leftCount = left.Count;
            long rightCount = right.Count;

            long numWays = (dp[(int)(leftCount + rightCount)][(int)leftCount] * CountBST(left, dp)) % MOD;
            numWays = (numWays * CountBST(right, dp)) % MOD;

            return (int)numWays;
        }

        public static int NumOfWays(int[] nums)
        {
            List<List<long>> dp = GenerateComb(nums.Length);
            return (int)((int)CountBST(nums.ToList(), dp) - 1 + MOD) % MOD;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {2,1,3};
            int[] nums2 = {3,4,5,1,2};
            int[] nums3 = {1,2,3};

            int result1 = Solution.NumOfWays(nums1);
            int result2 = Solution.NumOfWays(nums2);
            int result3 = Solution.NumOfWays(nums3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 5),
                ResultTester.CheckResult<int>(result3, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Reorder Array to Get Same BST");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}