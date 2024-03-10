// Intersection of Two Arrays


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IntersectionofTwoArrays
{
    public class Solution
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray(); 
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.Intersection(new int[]{1,2,2,1}, new int[]{2,2}), new int[]{2}),
                ResultTester.CheckResult<int[]>(Solution.Intersection(new int[]{4,9,5}, new int[]{9,4,9,8,4}), new int[]{4,9}),
            };
            return results;
        }
    }
}