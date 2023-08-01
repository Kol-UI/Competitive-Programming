// Coin Change II

/*
You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

Return the number of combinations that make up that amount. If that amount of money cannot be made up by any combination of the coins, return 0.

You may assume that you have an infinite number of each kind of coin.

The answer is guaranteed to fit into a signed 32-bit integer.

 

Example 1:

Input: amount = 5, coins = [1,2,5]
Output: 4
Explanation: there are four ways to make up the amount:
5=5
5=2+2+1
5=2+1+1+1
5=1+1+1+1+1

Example 2:

Input: amount = 3, coins = [2]
Output: 0
Explanation: the amount of 3 cannot be made up just with coins of 2.

Example 3:

Input: amount = 10, coins = [10]
Output: 1
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CoinChangeII
{
    public class Solution
    {
        static int[][]? dp;
        public static int Change(int amount, int[] coins) 
        {
            int n = coins.Length;
            dp = new int[n][];

            for(int i = 0; i < n; i++)
            {
                int[] arr = new int[amount+1];
                Array.Fill(arr, -1);
                dp[i] = arr;
            }

            return FindWays(n-1, amount, coins);
        }

        private static int FindWays(int index, int sum, int[] coins)
        {
            if(index == 0)
            {
                if(sum % coins[0] == 0)
                    return 1;
                else
                    return 0;
            }

            if(dp![index][sum] != -1)
                return dp[index][sum];

            int exclude = FindWays(index-1, sum, coins);
            int include = 0;
            if(coins[index] <= sum)
            include = FindWays(index, sum - coins[index], coins);

            return dp[index][sum] = include + exclude;        
        }
    }

    public class Test
    {
        public static bool[] TestCoinChangeII()
        {
            int amount1 = 5;
            int[] coins1 = {1,2,5};
            int amount2 = 3;
            int[] coins2 = {2};
            int amount3 = 10;
            int[] coins3 = {10};

            int result1_518 = Solution.Change(amount1, coins1);
            int result2_518 = Solution.Change(amount2, coins2);
            int result3_518 = Solution.Change(amount3, coins3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_518, 4),
                ResultTester.CheckResult<int>(result2_518, 0),
                ResultTester.CheckResult<int>(result3_518, 1)
            };
            return results;
        }
    }
}