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
}