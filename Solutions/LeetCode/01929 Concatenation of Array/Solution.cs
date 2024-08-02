// Concatenation of Array

/*
Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
Specifically, ans is the concatenation of two nums arrays.
Return the array ans.

Example 1:

Input: nums = [1,2,1]
Output: [1,2,1,1,2,1]
Explanation: The array ans is formed as follows:
- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
- ans = [1,2,1,1,2,1]

Example 2:

Input: nums = [1,3,2,1]
Output: [1,3,2,1,1,3,2,1]
Explanation: The array ans is formed as follows:
- ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]
- ans = [1,3,2,1,1,3,2,1]
*/
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConcatenationofArray
{
    public class Solution
    {
        public static int[] GetConcatenation(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] nums1_1929 = {1,2,1};
            int[] output1_1929 = Solution.GetConcatenation(nums1_1929);

            // Case 2
            int[] nums2_1929 = {1,3,2,1};
            int[] output2_1929 = Solution.GetConcatenation(nums2_1929);

            int[] expected1 = {1,2,1,1,2,1};
            int[] expected2 = {1,3,2,1,1,3,2,1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(output1_1929, expected1),
                ResultTester.CheckResult<int[]>(output2_1929, expected2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("1929");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}