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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestValidTriangleNumber()
        {
            int[] nums1 = {2,2,3,4};
            int[] nums2 = {4,2,3,4};
            int result1 = Solution.TriangleNumber(nums1);
            int result2 = Solution.TriangleNumber(nums2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Triangle Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestValidTriangleNumber());
        }
    }
}