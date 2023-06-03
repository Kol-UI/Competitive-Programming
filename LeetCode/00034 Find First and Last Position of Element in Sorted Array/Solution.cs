// Find First and Last Position of Element in Sorted Array


/*
Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]

Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]

Example 3:

Input: nums = [], target = 0
Output: [-1,-1]
*/

using System;
namespace CompetitiveProgramming.LeetCode.FindFirstandLastPositionofElementinSortedArray
{
    public class Solution
    {
        // Binary Search
        public static int[] SearchRange(int[] nums, int target)
        {
            var ans = new int[]{ -1,-1 };
            if(nums.Length == 0 || nums[0] > target || nums[nums.Length-1] < target)
                return ans;
            int st = 0;
            int end = nums.Length-1;

            while(st <= end)
            {
                var mid = st + (end - st) / 2;
                if(nums[mid] == target) 
                {
                    ans[0] = SearchRangeHelper(nums, target, st, mid, isLeft: true);
                    ans[1] = SearchRangeHelper(nums, target, mid, end, isLeft: false);
                    break;
                }
                else if(nums[mid] > target)
                    end = mid - 1;
                else
                    st = mid + 1;
            }

            return ans;
        }
        public static int SearchRangeHelper(int[] nums, int target, int st, int end, bool isLeft) {
            while(st <= end)
            {
                var mid = st + (end - st) / 2;
                if(nums[mid] == target)
                {
                    if(isLeft)
                    {
                        if((mid == 0 || nums[mid - 1] < target))
                            return mid;
                        else
                            end = mid - 1;
                    }
                    else
                    {
                        if((mid == nums.Length - 1 || nums[mid + 1] > target))
                            return mid;
                        else
                            st = mid + 1;
                    }
                }
                else if(nums[mid] > target)
                    end = mid - 1;
                else
                    st = mid + 1;
            }
            return -1;
        }
    }
}