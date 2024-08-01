// Search in Rotated Sorted Array II

/*
There is an integer array nums sorted in non-decreasing order (not necessarily with distinct values).

Before being passed to your function, nums is rotated at an unknown pivot index k (0 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,4,4,5,6,6,7] might be rotated at pivot index 5 and become [4,5,6,6,7,0,1,2,4,4].

Given the array nums after the rotation and an integer target, return true if target is in nums, or false if it is not in nums.

You must decrease the overall operation steps as much as possible.

 

Example 1:

Input: nums = [2,5,6,0,0,1,2], target = 0
Output: true

Example 2:

Input: nums = [2,5,6,0,0,1,2], target = 3
Output: false
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SearchinRotatedSortedArrayII
{
    public class Solution
    {
        public static bool Search(int[] nums, int target) 
        {
            int l = 0;
            int r = nums.Length - 1;
            int mid = 0;

            while(l <= r)
            {
                mid = l + (r - l) / 2;

                if(target == nums[mid])
                    return true;

                if(nums[l] < nums[mid])
                {
                    if(target < nums[mid] && target >= nums[l])
                        r = mid - 1;
                    else
                        l = mid + 1;
                }
                else if (nums[l] > nums[mid])
                {
                    if(target > nums[mid] && target <= nums[r])
                        l = mid + 1;
                    else
                        r = mid - 1;
                }
                else
                    l++;
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestSearchinRotatedSortedArrayII()
        {
            int[] nums1 = {2,5,6,0,0,1,2};
            int target1 = 0;
            int[] nums2 = {2,5,6,0,0,1,2};
            int target2 = 3;

            bool result1 = Solution.Search(nums1, target1);
            bool result2 = Solution.Search(nums2, target2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Search in Rotated Sorted Array II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSearchinRotatedSortedArrayII());
        }
    }
}