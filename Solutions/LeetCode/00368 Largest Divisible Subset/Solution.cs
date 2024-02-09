// Largest Divisible Subset


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LargestDivisibleSubset
{
    public class Solution 
    {
        public static IList<int> LargestDivisibleSubset(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return new List<int>();
            }

            Array.Sort(nums);
            int n = nums.Length;

            int[] dp = new int[n];
            int[] prev = new int[n];

            int maxIndex = 0;
            int maxSize = 1;

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                prev[i] = -1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] % nums[j] == 0 && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;

                        if (dp[i] > maxSize)
                        {
                            maxSize = dp[i];
                            maxIndex = i;
                        }
                    }
                }
            }

            IList<int> result = new List<int>();

            while (maxIndex != -1)
            {
                result.Add(nums[maxIndex]);
                maxIndex = prev[maxIndex];
            }

            result = result.Reverse().ToList();
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.LargestDivisibleSubset(new int[]{1,2,3}), new List<int>(){1,2}),
                ResultTester.CheckResult<IList<int>>(Solution.LargestDivisibleSubset(new int[]{1,2,4,8}), new List<int>(){1,2,4,8}),
            };

            return results;
        }
    }
}