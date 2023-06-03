// Special Array With X Elements Greater Than or Equal X

/*
You are given an array nums of non-negative integers. nums is considered special if there exists a number x such that there are exactly x numbers in nums that are greater than or equal to x.

Notice that x does not have to be an element in nums.

Return x if the array is special, otherwise, return -1. It can be proven that if nums is special, the value for x is unique.

 

Example 1:

Input: nums = [3,5]
Output: 2
Explanation: There are 2 values (3 and 5) that are greater than or equal to 2.

Example 2:

Input: nums = [0,0]
Output: -1
Explanation: No numbers fit the criteria for x.
If x = 0, there should be 0 numbers >= x, but there are 2.
If x = 1, there should be 1 number >= x, but there are 0.
If x = 2, there should be 2 numbers >= x, but there are 0.
x cannot be greater since there are only 2 numbers in nums.

Example 3:

Input: nums = [0,4,3,0,4]
Output: 3
Explanation: There are 3 values that are greater than or equal to 3.
*/

using System;
namespace CompetitiveProgramming.LeetCode.SpecialArrayWithXElementsGreaterThanorEqualX
{
    // Binary Search
    public class Solution
    {
        public static int SpecialArray(int[] nums)
        {
            var n = nums.Length;
            if (n == 1)
            {
                if (nums[0] >= n) return 1;
                else return -1;
            };

            Array.Sort(nums);

            var left = 1;
            var right = n;

            while (left <= right)
            {
                var mid = left + (right - left) /2;

                if (nums[n - mid] >= mid)
                {
                    if (n - mid == 0 || nums[n - mid - 1] < mid)
                    {
                        return mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    right = mid - 1;
                }

            }

            return -1;
        }
    }
}