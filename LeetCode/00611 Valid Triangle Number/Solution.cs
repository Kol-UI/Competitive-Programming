// Valid Triangle Number

/*
Given an integer array nums, return the number of triplets chosen from the array that can make triangles if we take them as side lengths of a triangle.

 

Example 1:

Input: nums = [2,2,3,4]
Output: 3
Explanation: Valid combinations are: 
2,3,4 (using the first 2)
2,3,4 (using the second 2)
2,2,3

Example 2:

Input: nums = [4,2,3,4]
Output: 4
*/

using System;
namespace CompetitiveProgramming.LeetCode.ValidTriangleNumber
{
    public class Solution
    {
        public static int TriangleNumber(int[] nums)
        {
            int result = 0;
            Array.Sort(nums);
            
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    int start = j + 1;
                    int end = nums.Length - 1;

                    while(start <= end)
                    {
                        int mid = (start + end) / 2;
                        if(nums[mid] < sum)
                        {
                            int total = mid - start + 1;
                            result += total;
                            start = mid + 1;
                        }
                        else
                        {
                            end = mid -1;
                        }
                    }
                }
            }

            return result;
        }
    }
}