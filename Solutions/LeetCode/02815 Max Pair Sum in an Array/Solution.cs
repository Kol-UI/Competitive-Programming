// Max Pair Sum in an Array



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaxPairSuminanArray
{
    public class Solution
    {
        public static int MaxSum(int[] nums)
        {
            int result = -1;
            Dictionary<int, int> map = new();

            for(int i = 0; i < nums.Length; i++)
            {
                int maxDigit = GetMaxDigit(nums[i]);
                if(map.ContainsKey(maxDigit))
                {
                    result = Math.Max(result, map[maxDigit] + nums[i]);
                    map[maxDigit] = Math.Max(map[maxDigit], nums[i]);
                }
                else
                {
                    map.TryAdd(maxDigit, 0);
                    map[maxDigit] = nums[i];
                }
            }

            return result;
        }

        private static int GetMaxDigit(int num)
        {
            int maxDigit = 0;

            while(num != 0)
            {
                maxDigit = Math.Max(maxDigit, num%10);
                num /= 10; 
            }

            return maxDigit;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxSum(new int[]{51,71,17,24,42}), 88),
                ResultTester.CheckResult<int>(Solution.MaxSum(new int[]{1,2,3,4}), -1),
            };
            return results;
        }
    }
}