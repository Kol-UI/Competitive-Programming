// Number of Longest Increasing Subsequence

/*
Given an integer array nums, return the number of longest increasing subsequences.

Notice that the sequence has to be strictly increasing.

 

Example 1:

Input: nums = [1,3,5,4,7]
Output: 2
Explanation: The two longest increasing subsequences are [1, 3, 4, 7] and [1, 3, 5, 7].

Example 2:

Input: nums = [2,2,2,2,2]
Output: 5
Explanation: The length of the longest increasing subsequence is 1, and there are 5 increasing subsequences of length 1, so output 5.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NumberofLongestIncreasingSubsequence
{
    public class Solution
    {
        public static int FindNumberOfLIS(int[] nums)
        {
            if (nums.Length == 1) return 1;
            
            int[] len = new int[nums.Length];
            int[] count = new int[nums.Length];

            len[0] = 1;
            count[0] = 1;

            int maxLen = 1;
            int sum = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                len[i] = 1;
                count[i] = 1;

                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (len[j] + 1 == len[i]) count[i] += count[j];
                        else if (len[j] + 1 > len[i])
                        {
                            len[i] = len[j] + 1;
                            count[i] = count[j];
                        }
                    }
                }

                if (maxLen == len[i]) sum += count[i];
                else if (len[i] > maxLen)
                {
                    maxLen = len[i]; sum = count[i];
                }
            }
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] case1 = {1,3,5,4,7};
            int[] case2 = {2,2,2,2,2};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindNumberOfLIS(case1), 2),
                ResultTester.CheckResult<int>(Solution.FindNumberOfLIS(case2), 5),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Number of Longest Increasing Subsequence");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}