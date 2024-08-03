// Minimize Maximum Pair Sum in Array

/*
The pair sum of a pair (a,b) is equal to a + b. The maximum pair sum is the largest pair sum in a list of pairs.

For example, if we have pairs (1,5), (2,3), and (4,4), the maximum pair sum would be max(1+5, 2+3, 4+4) = max(6, 5, 8) = 8.
Given an array nums of even length n, pair up the elements of nums into n / 2 pairs such that:

Each element of nums is in exactly one pair, and
The maximum pair sum is minimized.
Return the minimized maximum pair sum after optimally pairing up the elements.

 

Example 1:

Input: nums = [3,5,2,3]
Output: 7
Explanation: The elements can be paired up into pairs (3,3) and (5,2).
The maximum pair sum is max(3+3, 5+2) = max(6, 7) = 7.

Example 2:

Input: nums = [3,5,4,2,4,6]
Output: 8
Explanation: The elements can be paired up into pairs (3,5), (4,4), and (6,2).
The maximum pair sum is max(3+5, 4+4, 6+2) = max(8, 8, 8) = 8.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimizeMaximumPairSuminArray
{
    public class Solution
    {
        public static int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1;
            int minMaxPairSum = int.MinValue;

            while (left < right)
            {
                int currentPairSum = nums[left] + nums[right];

                minMaxPairSum = Math.Max(minMaxPairSum, currentPairSum);

                left++;
                right--;
            }

            return minMaxPairSum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int [] arr1 = {3,5,2,3};
            int [] arr2 = {3,5,4,2,4,6};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinPairSum(arr1), 7),
                ResultTester.CheckResult<int>(Solution.MinPairSum(arr2), 8),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimize Maximum Pair Sum in Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}