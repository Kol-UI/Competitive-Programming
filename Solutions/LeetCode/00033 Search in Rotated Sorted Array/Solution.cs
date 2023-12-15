// Search in Rotated Sorted Array

/*
There is an integer array nums sorted in ascending order (with distinct values).

Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].

Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4

Example 2:

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1

Example 3:

Input: nums = [1], target = 0
Output: -1
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SearchinRotatedSortedArray
{
    public class Solution
    {
        // Binary Search
        public static int Search(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    return i;
                }
            }
            return -1; 
        }
    }

    public class Test
    {
        public static bool[] TestSearchinRotatedSortedArray()
        {
            int[] arr33_1 = {4,5,6,7,0,1,2};
            int[] arr33_2 = {4,5,6,7,0,1,2};
            int target33_1 = 0;
            int target33_2 = 3;

            int output1_33 = 4;
            int output2_33 = -1;

            int result1 = Solution.Search(arr33_1, target33_1);
            int result2 = Solution.Search(arr33_2, target33_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_33),
                ResultTester.CheckResult<int>(result2, output2_33)
            };
            return results;
        }
    }
}
