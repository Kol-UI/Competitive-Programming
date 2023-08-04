﻿using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RunningSumof1dArray
{
    public class Solution
	{
        //Given an array nums.We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

        //Return the running sum of nums.

        //Input: nums = [1,2,3,4]
        //Output: [1,3,6,10]
        //Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

        public static int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums = {1,2,3,4};
            int[] result1 = Solution.RunningSum(nums);
            int[] expected1 = {1,3,6,10};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1)
            };
            return results;
        }
    }
}

