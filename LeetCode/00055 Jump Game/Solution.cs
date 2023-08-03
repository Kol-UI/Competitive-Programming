// Jump Game

/*
You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

Return true if you can reach the last index, or false otherwise.

 

Example 1:

Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.

Example 2:

Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.JumpGame
{
    public class Solution
    {
        public static bool CanJump(int[] nums) 
        {
            int power = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                power--;
                power = Math.Max(power, nums[i]);

                if (power == 0 && i != nums.Length - 1)
                    return false;
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestJumpGame()
        {
            int[] nums1_55 = { 2,3,1,1,4 };
            int[] nums2_55 = { 3,2,1,0,4 };
            bool output1_55 = true;
            bool output2_55 = false;

            bool result1_55 = Solution.CanJump(nums1_55);
            bool result2_55 = Solution.CanJump(nums2_55);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1_55, output1_55),
                ResultTester.CheckResult<bool>(result2_55, output2_55)
            };
            return results;
        }
    }
}