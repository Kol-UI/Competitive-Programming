// Largest Perimeter Triangle

/*
Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

 

Example 1:

Input: nums = [2,1,2]
Output: 5
Explanation: You can form a triangle with three side lengths: 1, 2, and 2.

Example 2:

Input: nums = [1,2,1,10]
Output: 0
Explanation: 
You cannot use the side lengths 1, 1, and 2 to form a triangle.
You cannot use the side lengths 1, 1, and 10 to form a triangle.
You cannot use the side lengths 1, 2, and 10 to form a triangle.
As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestPerimeterTriangle
{
    public class Solution
    {
        public static int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);
            for(int i = nums.Length - 3; i >= 0; --i)
            {
                if(nums[i] + nums[i + 1] > nums[i + 2])
                {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }
            return 0;
        }
    }

    public class Test
    {
        public static bool[] TestLargestPerimeterTriangle()
        {
            int[] case1_976 = {2,1,2};
            int[] case2_976 = {1,2,1,10};
            int result1_976 = Solution.LargestPerimeter(case1_976);
            int result2_976 = Solution.LargestPerimeter(case2_976);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_976, 5),
                ResultTester.CheckResult<int>(result2_976, 0)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Perimeter Triangle");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestLargestPerimeterTriangle());
        }
    }
}