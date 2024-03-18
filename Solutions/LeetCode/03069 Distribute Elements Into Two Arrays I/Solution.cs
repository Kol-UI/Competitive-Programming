// Distribute Elements Into Two Arrays I


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DistributeElementsIntoTwoArraysI
{
    public class Solution
    {
        public static int[] ResultArray(int[] nums)
        {
            var list0 = new List<int> { nums[0] };
            var list1 = new List<int> { nums[1] };
            for (int i = 2; i < nums.Length; i++)
            {
                if (list0[list0.Count - 1] > list1[list1.Count - 1])
                {
                    list0.Add(nums[i]);
                }
                else
                {
                    list1.Add(nums[i]);
                }
            }
            var rs = new int[nums.Length];
            for (int i = 0; i < list0.Count; i++)
            {
                rs[i] = list0[i];
            }
            for (int i = 0; i < list1.Count; i++)
            {
                rs[list0.Count + i] = list1[i];
            }
            return rs;
        }
    }
}