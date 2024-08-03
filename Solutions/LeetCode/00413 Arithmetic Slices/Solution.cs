// Arithmetic Slices

/*
An integer array is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.

For example, [1,3,5,7,9], [7,7,7,7], and [3,-1,-5,-9] are arithmetic sequences.
Given an integer array nums, return the number of arithmetic subarrays of nums.

A subarray is a contiguous subsequence of the array.

 

Example 1:

Input: nums = [1,2,3,4]
Output: 3
Explanation: We have 3 arithmetic slices in nums: [1, 2, 3], [2, 3, 4] and [1,2,3,4] itself.

Example 2:

Input: nums = [1]
Output: 0
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ArithmeticSlices
{
    public class Solution
    {
        public static int NumberOfArithmeticSlices(int[] nums)
        {
            var list = new List<int>();
            int count = 2;

            for(int i = 2; i<nums.Length; i++)
            {
                if(nums[i] + nums[i-2] == nums[i-1]*2)
                {
                    count++;
                }
                else
                {
                    if(count > 2)
                    {
                        list.Add(count);
                    }   
                    count = 2;
                }
            }
            if(count > 2)
            {
                list.Add(count);
            }

            if(!list.Any())
            {
                return 0;
            }

            var max = list.Max();        
            int[] f = new int[max+1];
            f[3] = 1;

            for(int i = 4; i <= max; i++)
            {
                f[i] = f[i-1] + i - 2;
            }

            int sum = 0;

            foreach(var m in list)
            {
                sum += f[m];
            }
            
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestArithmeticSlices()
        {
            int[] nums1 = {1,2,3,4};
            int[] nums2 = {1};
            int result1 = Solution.NumberOfArithmeticSlices(nums1);
            int result2 = Solution.NumberOfArithmeticSlices(nums2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Arithmetic Slices");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestArithmeticSlices());
        }
    }
}