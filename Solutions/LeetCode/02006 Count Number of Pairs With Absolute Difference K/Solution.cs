// Count Number of Pairs With Absolute Difference K

/*
Given an integer array nums and an integer k, return the number of pairs (i, j) where i < j such that |nums[i] - nums[j]| == k.

The value of |x| is defined as:

x if x >= 0.
-x if x < 0.
 

Example 1:

Input: nums = [1,2,2,1], k = 1
Output: 4
Explanation: The pairs with an absolute difference of 1 are:
- [1,2,2,1]
- [1,2,2,1]
- [1,2,2,1]
- [1,2,2,1]

Example 2:

Input: nums = [1,3], k = 3
Output: 0
Explanation: There are no pairs with an absolute difference of 3.

Example 3:

Input: nums = [3,2,1,5,4], k = 2
Output: 3
Explanation: The pairs with an absolute difference of 2 are:
- [3,2,1,5,4]
- [3,2,1,5,4]
- [3,2,1,5,4]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountNumberofPairsWithAbsoluteDifferenceK
{
    public class Solution
    {
        public static int CountKDifference(int[] nums, int k)
        {
            int result = 0;
            int temp = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    result = Math.Abs(nums[i] - nums[j]);
                    if (k == result)
                    {
                        temp += 1;
                    }
                }
            }

        return temp;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,2,2,1};
            int k1 = 1;

            int[] nums2 = {1,3};
            int k2 = 3;

            int[] nums3 = {3,2,1,5,4};
            int k3 = 2;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountKDifference(nums1, k1), 4),
                ResultTester.CheckResult<int>(Solution.CountKDifference(nums2, k2), 0),
                ResultTester.CheckResult<int>(Solution.CountKDifference(nums3, k3), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2006");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}