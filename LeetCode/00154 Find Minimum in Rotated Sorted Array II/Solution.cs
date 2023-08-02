// Find Minimum in Rotated Sorted Array II

/*
Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,4,4,5,6,7] might become:

[4,5,6,7,0,1,4] if it was rotated 4 times.
[0,1,4,4,5,6,7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

Given the sorted rotated array nums that may contain duplicates, return the minimum element of this array.

You must decrease the overall operation steps as much as possible.

 

Example 1:

Input: nums = [1,3,5]
Output: 1

Example 2:

Input: nums = [2,2,2,0,1]
Output: 0
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindMinimuminRotatedSortedArrayII
{
    public class Solution
    {
        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else
                {
                    right--;
                }
            }
            
            return nums[left];
        }
    }

    public class Test
    {
        public static bool[] TestFindMinimuminRotatedSortedArrayII()
        {
            int[] nums1 = {1,3,5};
            int[] nums2 = {2,2,2,0,1};
            int result1 = Solution.FindMin(nums1);
            int result2 = Solution.FindMin(nums2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 0)
            };
            return results;
        }
    }
}