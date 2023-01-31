using System;

namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStockwithCooldown
{
    public class Solution
    {
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.

        //Find the maximum profit you can achieve. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times) with the following restrictions:

        //After you sell your stock, you cannot buy stock on the next day(i.e., cooldown one day).
        //Note: You may not engage in multiple transactions simultaneously(i.e., you must sell the stock before you buy again).


        //Example 1:
        //Input: prices = [1,2,3,0,2]
        //        Output: 3
        //Explanation: transactions = [buy, sell, cooldown, buy, sell]
        //Example 2:
        //Input: prices = [1]
        //        Output: 0

        public static int MaxProfit(int[] prices)
        {
            int[] buy = new int[prices.Length];
            int[] sell = new int[prices.Length];

            if (prices.Length <= 1)
            {
                return 0;
            }
            if (prices.Length == 2)
            {
                return Math.Max(0, prices[1] - prices[0]);
            }

            buy[0] = -prices[0];
            sell[0] = 0;

            buy[1] = Math.Max(-prices[0], -prices[1]);
            sell[1] = Math.Max(0, prices[1] - prices[0]);

            for (int i = 2; i < prices.Length; ++i)
            {
                buy[i] = Math.Max(buy[i - 1], sell[i - 2] - prices[i]);
                sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i]);
            }

            return Math.Max(buy[prices.Length - 1], sell[prices.Length - 1]);
        }
    }
}

