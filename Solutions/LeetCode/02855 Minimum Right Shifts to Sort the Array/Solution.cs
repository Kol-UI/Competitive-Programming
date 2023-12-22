// Minimum Right Shifts to Sort the Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumRightShiftstoSorttheArray
{
    public class Solution
    {
        public static int MinimumRightShifts(IList<int> nums)
        {
            var tmp = nums.Select((item, index) => new {item, index}).OrderBy(o => o.item).ToArray();
            var len = tmp.Length;
            for(int i = 1; i < len; i++)
            {
                if((tmp[i - 1].index + 1) % len != tmp[i].index) return -1;
            }
            return (len - tmp[0].index) % len;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {3,4,5,1,2};
            int[] nums2 = {1,3,5};
            int[] nums3 = {2,1,4};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumRightShifts(nums1), 2),
                ResultTester.CheckResult<int>(Solution.MinimumRightShifts(nums2), 0),
                ResultTester.CheckResult<int>(Solution.MinimumRightShifts(nums3), -1),
            };
            return results;
        }
    }
}