// Maximum Average Subarray I

/*
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75

Example 2:

Input: nums = [5], k = 1
Output: 5.00000
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumAverageSubarrayI
{
    public class Solution
    {
        // Sliding Window
        public static double FindMaxAverage(int[] nums, int k)
        {
            double WindowSum = 0;
            
            for(int i = 0; i < k; i++)
            {
                WindowSum = WindowSum + nums[i];
            }

            double max = WindowSum / k;

            for(int i = k; i < nums.Length; i++)
            {
                WindowSum = WindowSum + nums[i] - nums[i-k];
                max = Math.Max(max, WindowSum / k);
            }

            return max;
        }
    }

    public class Test
    {
        public static bool[] TestMaximumAverageSubarrayI()
        {
            // Case 1
            int[] nums1 = {1,12,-5,-6,50,3};
            int k1 = 4;
            double result1 = Solution.FindMaxAverage(nums1, k1);

            // Case 2
            int[] nums2 = {5};
            int k2 = 1;
            double result2 = Solution.FindMaxAverage(nums2, k2);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1, 12.75000),
                ResultTester.CheckResult<double>(result2, 5.00000)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum Average Subarray");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestMaximumAverageSubarrayI());
        }
    }
}