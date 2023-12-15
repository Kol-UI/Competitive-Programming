// Move Zeroes

/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:

Input: nums = [0]
Output: [0]
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MoveZeroes
{
    public class Solution
    {
        // This function takes an integer array nums as input and moves all the zeros in the array to the end
        // while maintaining the relative order of the non-zero elements.
        public static void MoveZeroes(int[] nums) 
        {
            // Initializing zIndex to 0 which represents the index of the first zero in the array or the end of the non-zero elements.
            int zIndex = 0;
            while(zIndex < nums.Length && nums[zIndex] != 0) 
                zIndex++;

            int r = zIndex + 1;

            while(r < nums.Length)
            {
                if(nums[r] != 0)
                {
                    nums[zIndex] = nums[r];
                    nums[r] = 0;
                    zIndex++;
                }

                r++;
            }

        }
    }
}