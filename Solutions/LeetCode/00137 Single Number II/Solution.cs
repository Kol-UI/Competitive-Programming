// Single Number II


/*
Given an integer array nums where every element appears three times except for one, which appears exactly once. Find the single element and return it.

You must implement a solution with a linear runtime complexity and use only constant extra space.

 

Example 1:

Input: nums = [2,2,3,2]
Output: 3

Example 2:

Input: nums = [0,1,0,1,0,1,99]
Output: 99
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SingleNumberII
{
	public class Solution
    {
        public static int SingleNumber(int[] nums)
        {
            int ones = 0;
            int twos = 0;
        
            foreach (int num in nums) 
            {
                ones = (ones ^ num) & ~twos;
                twos = (twos ^ num) & ~ones;
            }
            
            return ones;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] case1 = {2,2,3,2};
            int[] case2 = {0,1,0,1,0,1,99};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SingleNumber(case1), 3),
                ResultTester.CheckResult<int>(Solution.SingleNumber(case2), 99),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Single Number II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}