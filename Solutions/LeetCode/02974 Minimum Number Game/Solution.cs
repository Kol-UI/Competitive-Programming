// Minimum Number Game



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumNumberGame
{
    public class Solution
    {
        public static int[] NumberGame(int[] nums)
        {
            int value = 0;
            Array.Sort(nums);
            
            for(int i = 0; i < nums.Length; i += 2)
            {
                value = nums[i];
                nums[i] = nums[i+1];
                nums[i+1] = value;
            }

            return nums;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.NumberGame(new int[]{5,4,2,3}), new int[]{3,2,5,4}),
                ResultTester.CheckResult<int[]>(Solution.NumberGame(new int[]{2,5}), new int[]{5,2}),
            };
            return results;
        }
    }
}