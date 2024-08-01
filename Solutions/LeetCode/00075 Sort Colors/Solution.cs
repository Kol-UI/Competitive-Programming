// Sort Colors

/*
Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.

We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

You must solve this problem without using the library's sort function.

 

Example 1:

Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

Example 2:

Input: nums = [2,0,1]
Output: [0,1,2]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SortColors
{
    public class Solution
    {
        public static void SortColors(int[] nums)
        {
            int p = 0;
            int p1 = 0;
            int p2 = nums.Length - 1;
                
            while(p1 <= p2)
            {
                if(nums[p1] == 0)
                {
                    nums[p1] = nums[p];
                    nums[p] = 0;
                    p++;
                    p1++;

                }
                else if(nums[p1] == 2)
                {
                    nums[p1] = nums[p2];
                    nums[p2] = 2;
                    p2--;
                }
                else
                {
                    p1++;
                }
            }
            
            // For test
            PrintHelper.PrintArray(nums);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Colors");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}