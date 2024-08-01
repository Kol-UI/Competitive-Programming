// Find the Duplicate Number

/*
Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.

There is only one repeated number in nums, return this repeated number.

You must solve the problem without modifying the array nums and uses only constant extra space.

 

Example 1:

Input: nums = [1,3,4,2,2]
Output: 2

Example 2:

Input: nums = [3,1,3,4,2]
Output: 3
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheDuplicateNumber
{
    public class Solution 
    {
        public static int FindDuplicate(int[] nums) 
        {
            bool[] found = new bool[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                if(found[nums[i]]) return nums[i];
                found[nums[i]] = true;
            }
            
            return 0;
        }
    }

    public class Test
    {
        public static bool[] TestFindtheDuplicateNumber()
        {
            int[] nums1 = {1,3,4,2,2};
            int[] nums2 = {3,1,3,4,2};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindDuplicate(nums1), 2),
                ResultTester.CheckResult<int>(Solution.FindDuplicate(nums2), 3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Duplicate Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestFindtheDuplicateNumber());
        }
    }
}