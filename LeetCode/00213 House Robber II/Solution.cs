using System;

namespace CompetitiveProgramming.LeetCode.HouseRobberII
{
    public class Solution
    {
        //You are a professional robber planning to rob houses along a street.Each house has a certain amount of money stashed. All houses at this place are arranged in a circle.
        //That means the first house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected, and it will automatically contact the police if two adjacent houses were broken into on the same night.

        //Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

        //Example 1:

        //Input: nums = [2, 3, 2]
        //Output: 3
        //Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent houses.

        //Example 2:

        //Input: nums = [1,2,3,1]
        //Output: 4
        //Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
        //Total amount you can rob = 1 + 3 = 4.

        //Example 3:

        //Input: nums = [1,2,3]
        //Output: 3

        public static int Rob(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Max(nums[0], nums[1]);
            if (nums.Length == 3) return Math.Max(Math.Max(nums[0], nums[1]), nums[2]);

            int[] case1 = new int[nums.Length];
            int[] case2 = new int[nums.Length];

            case1[1] = nums[1];
            case2[0] = nums[0];
            case2[1] = Math.Max(nums[1], nums[0]);
            for (int i = 2; i < nums.Length; ++i)
            {
                case1[i] = Math.Max(case1[i - 1], nums[i] + case1[i - 2]);
            }
            for (int i = 2; i < nums.Length - 1; ++i)
            {
                case2[i] = Math.Max(case2[i - 1], nums[i] + case2[i - 2]);
            }
            return Math.Max(case1[case1.Length - 1], case2[case2.Length - 2]);
        }
    }
}

