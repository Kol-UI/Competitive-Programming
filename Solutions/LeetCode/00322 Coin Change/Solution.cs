// Coin Change

/*
You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

You may assume that you have an infinite number of each kind of coin.

 

Example 1:

Input: coins = [1,2,5], amount = 11
Output: 3
Explanation: 11 = 5 + 5 + 1

Example 2:

Input: coins = [2], amount = 3
Output: 2

Example 3:

Input: coins = [1], amount = 0
Output: -1
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CoinChange
{
    public class Solution
    {
        static Dictionary<int,int> dp = new Dictionary<int,int>();
        public static int CoinChange(int[] coins, int amount)
        {
            if(amount == 0) return 0;
            Array.Sort(coins);
            return GetCoinChange(coins, amount);
        }

        public static int GetCoinChange(int[] coins, int amount)
        {
            if(dp.ContainsKey(amount))
                return dp[amount];
                
            int minCoins = -1;
            for(int i = coins.Length - 1; i >= 0; i--)
            {
                if(amount < coins[i])
                    continue;
                    
                if(amount == coins[i])
                {
                    return 1;
                }
                else
                {
                    var cnumber = GetCoinChange(coins, amount - coins[i]);
                    if(cnumber != -1 && (minCoins == -1 || cnumber < minCoins))
                        minCoins = cnumber;
                }
            }
            dp.Add(amount, minCoins != -1 ? minCoins + 1 : -1);
            return dp[amount];
        }
    }

    public class Test
    {
        public static bool[] TestCoinChange()
        {
            int[] coins1 = {1,2,5};
            int amount1 = 11;
            int[] coins2 = {2};
            int amount2 = 3;
            int[] coins3 = {1};
            int amount3 = 0;

            int result1_322 = Solution.GetCoinChange(coins1, amount1);
            int result2_322 = Solution.GetCoinChange(coins2, amount2);
            int result3_322 = Solution.GetCoinChange(coins3, amount3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_322, 3),
                ResultTester.CheckResult<int>(result2_322, 2),
                ResultTester.CheckResult<int>(result3_322, -1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Coin Change");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCoinChange());
        }
    }
}