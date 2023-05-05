// Max Consecutive Ones III

/*
Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's.

 

Example 1:

Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
Output: 6
Explanation: [1,1,1,0,0,1,1,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

Example 2:

Input: nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
Output: 10
Explanation: [0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.
*/

using System;
namespace CompetitiveProgramming.LeetCode.MaxConsecutiveOnesIII
{
    public class Solution
    {
        public static int LongestOnes(int[] nums, int k)
        {
            // Sliding Window
            int left = 0;
            int maxCons = 0;

            for(int right = 0; right < nums.Length; right++)
            {
                k += nums[right] == 0 ? -1 : 0;
                if(k < 0)
                {
                    k+= nums[left] == 0 ? 1 : 0;
                    left++; 
                }
                else
                {
                    maxCons = Math.Max(maxCons, right - left + 1);
                }
            }
            return maxCons;
        }
    }   
}