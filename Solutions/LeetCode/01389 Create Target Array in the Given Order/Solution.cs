// Create Target Array in the Given Order


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CreateTargetArrayintheGivenOrder
{
    public class Solution
    {
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] target = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                int value = index[i];
                for(int j = i; j > value; j--)
                {
                    target[j] = target[j - 1];
                }
                target[value] = num;
            }
            return target;
        }
    }
}