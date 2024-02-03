// Partition Array for Maximum Sum

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PartitionArrayforMaximumSum
{
    public class Solution
    {
        public static int MaxSumAfterPartitioning(int[] arr, int k)
        {
            int n = arr.Length;
            int[] dp = new int[n + 1];

            for(int i = 0; i < n; i++)
            {
                int curMax = 0, curSum = 0;
                for(int j = i; j > Math.Max(-1, i - k); j--)
                {
                    if(curMax < arr[j])
                        curMax = arr[j];
                    int temp = curMax * (i - j + 1) + dp[j];
                    if(curSum < temp)
                        curSum = temp;
                }
                dp[i + 1] = curSum;
            }
            return dp[n];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxSumAfterPartitioning(new int[]{1,15,7,9,2,5,10}, 3), 84),
                ResultTester.CheckResult<int>(Solution.MaxSumAfterPartitioning(new int[]{1,4,1,5,7,3,6,1,9,9,3}, 4), 83),
                ResultTester.CheckResult<int>(Solution.MaxSumAfterPartitioning(new int[]{1}, 1), 1),
            };

            return results;
        }
    }
}