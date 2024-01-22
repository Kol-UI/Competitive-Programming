// Set Mismatch


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SetMismatch
{
    public class Test
    {
        public class Solution
        {
            public static int[] FindErrorNums(int[] nums)
            {
                int first = nums.GroupBy(x => x).Where(g => g.Count() == 2).Select(x => x.Key).First();
                int second = Enumerable.Range(1, nums.Length).Except(nums).First();

                return new int[] { first, second }; 
            }
        }

        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindErrorNums(new int[]{1,2,2,4}), new int[]{2,3}),
                ResultTester.CheckResult<int[]>(Solution.FindErrorNums(new int[]{1,1}), new int[]{1,2}),
            };
            return results;
        }
    }
}