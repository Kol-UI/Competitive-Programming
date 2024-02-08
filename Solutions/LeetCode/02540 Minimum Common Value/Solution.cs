// Minimum Common Value


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumCommonValue
{
    public class Solution
    {
        public static int GetCommon(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>(nums2);

            var min = int.MaxValue;
            for (var i = 0; i < nums1.Length; i++)
            {
                if (set.Contains(nums1[i]))
                {
                    min = Math.Min(min, nums1[i]);
                }
            }

            return min == int.MaxValue ? -1 : min;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.GetCommon(new int[]{1,2,3}, new int[]{2,4}), 2),
                ResultTester.CheckResult<int>(Solution.GetCommon(new int[]{1,2,3,6}, new int[]{2,3,4,5}), 2),
            };

            return results;
        }
    }
}