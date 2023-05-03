// Product of Array Except Self

/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
*/


using System;
namespace CompetitiveProgramming.LeetCode.ProductofArrayExceptSelf
{
    public class Solution
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var arrLength = nums.Length;
            var output = new int[arrLength];
        
            for (int i = 0, prev = 1; i < arrLength; i++)
            {
                output[i] = prev;
                prev = nums[i] * prev;
            }
        
            for (int i = arrLength - 1, prev = 1; i >= 0; i--)
            {
                output[i] = output[i] * prev;
                prev = nums[i] * prev;
            }
            return output;
        }
    }
}