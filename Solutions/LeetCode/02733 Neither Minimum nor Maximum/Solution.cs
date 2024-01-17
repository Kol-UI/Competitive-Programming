// Neither Minimum nor Maximum


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NeitherMinimumnorMaximum
{
    public class Solution
    {
        public static int FindNonMinOrMax(int[] nums)
        {
            if (nums.Length <= 2)
                return -1;
            
            int min = Math.Min(nums[0], nums[1]);
            int max = Math.Max(nums[0], nums[1]);

            if (nums[2] > min && nums[2] < max)
                return nums[2];
            else if (nums[2] < min)
                return min;
            else
                return max;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindNonMinOrMax(new int[]{3,2,1,4}), 2),
                ResultTester.CheckResult<int>(Solution.FindNonMinOrMax(new int[]{1,2}), -1),
                ResultTester.CheckResult<int>(Solution.FindNonMinOrMax(new int[]{2,1,3}), 2),
            };
            return results;
        }
    }
}