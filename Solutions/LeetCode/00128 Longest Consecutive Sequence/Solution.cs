// Longest Consecutive Sequence


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LongestConsecutiveSequence
{
    public class Solution
    {
        public static int LongestConsecutive(int[] nums)
        {
            if(nums.Length < 2)
                return nums.Length;

            int result = 1;
            int max = 1;

            Array.Sort(nums);

            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] - nums[i - 1] == 1)
                {
                    result++;
                    max = Math.Max(result, max);
                }
                else if(nums[i] == nums[i - 1])
                    continue;
                else
                    result = 1;
            }
            return max;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LongestConsecutive(new int[]{100,4,200,1,3,2}), 4),
                ResultTester.CheckResult<int>(Solution.LongestConsecutive(new int[]{0,3,7,2,5,8,4,6,0,1}), 9),
            };
            return results;
        }
    }
}