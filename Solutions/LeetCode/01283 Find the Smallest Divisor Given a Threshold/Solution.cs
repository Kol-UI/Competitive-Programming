// Find the Smallest Divisor Given a Threshold

/*
Given an array of integers nums and an integer threshold, we will choose a positive integer divisor, divide all the array by it, and sum the division's result. Find the smallest divisor such that the result mentioned above is less than or equal to threshold.

Each result of the division is rounded to the nearest integer greater than or equal to that element. (For example: 7/3 = 3 and 10/2 = 5).

The test cases are generated so that there will be an answer.

 

Example 1:

Input: nums = [1,2,5,9], threshold = 6
Output: 5
Explanation: We can get a sum to 17 (1+2+5+9) if the divisor is 1. 
If the divisor is 4 we can get a sum of 7 (1+1+2+3) and if the divisor is 5 the sum will be 5 (1+1+1+2). 


Example 2:

Input: nums = [44,22,33,11,1], threshold = 5
Output: 44

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheSmallestDivisorGivenaThreshold
{
    public class Solution
    {
        public static int SmallestDivisor(int[] nums, int threshold)
        {
            var res = Int32.MaxValue;
            var n = nums.Length;

            var left = 1;
            var right = 1000000;

            while (left <= right)
            {
                var divisor = left + (right - left) / 2;

                var sum = 0;
                foreach(var num in nums)
                {
                    sum += num / divisor + (num % divisor > 0 ? 1 : 0);
                }

                if (sum <= threshold)
                {
                    res = Math.Min(res, divisor);
                    right = divisor - 1;
                }
                else
                {
                    left = divisor + 1;
                }
            }

            return res;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,2,5,9}; int threshold1 = 6;
            int[] nums2 = {44,22,33,11,1}; int threshold2 = 5;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SmallestDivisor(nums1, threshold1), 5),
                ResultTester.CheckResult<int>(Solution.SmallestDivisor(nums2, threshold2), 44),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find the Smallest Divisor Given a Threshold");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}