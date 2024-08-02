// Squares of a Sorted Array

/*
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].

Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SquaresofaSortedArray
{
    public class Solution
    {
        public static int[] SortedSquares(int[] nums)
        {
            var length = nums.Length;

            if (length == 0)
            {
                return Array.Empty<int>();
            }
            else if (length == 1)
            {
                return new[] { nums[0] * nums[0] };
            }

            var result = new int[length];
            var left = 0;
            var right = length - 1;
            var index = right;
            var leftValue = nums[left] * nums[left];
            var rightValue = nums[right] * nums[right];

            while (left < right)
            {
                if (leftValue < rightValue)
                {
                    result[index--] = rightValue;
                    right--;
                    rightValue = nums[right] * nums[right];
                }
                else if (leftValue > rightValue)
                {
                    result[index--] = leftValue;
                    left++;
                    leftValue = nums[left] * nums[left];
                }
                else
                {
                    result[index--] = leftValue;
                    result[index--] = rightValue;
                    left++;
                    right--;
                    leftValue = nums[left] * nums[left];
                    rightValue = nums[right] * nums[right];
                }
            }

            if (left == right)
            {
                result[index] = leftValue;
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestSquaresofaSortedArray()
        {
            int[] nums1 = {-4, -1, 0, 3, 10};
            int[] output1 = {0, 1, 9, 16, 100};

            int[] nums2 = {-7, -3, 2, 3, 11};
            int[] output2 = {4, 9, 9, 49, 121};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SortedSquares(nums1), output1),
                ResultTester.CheckResult<int[]>(Solution.SortedSquares(nums2), output2)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Squares of a Sorted Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestSquaresofaSortedArray());
        }
    }
}