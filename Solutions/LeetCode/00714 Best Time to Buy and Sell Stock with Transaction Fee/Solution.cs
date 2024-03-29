// Best Time to Buy and Sell Stock with Transaction Fee

/*
You are given an array prices where prices[i] is the price of a given stock on the ith day, and an integer fee representing a transaction fee.

Find the maximum profit you can achieve. You may complete as many transactions as you like, but you need to pay the transaction fee for each transaction.

Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).

 

Example 1:

Input: prices = [1,3,2,8,4,9], fee = 2
Output: 8
Explanation: The maximum profit can be achieved by:
- Buying at prices[0] = 1
- Selling at prices[3] = 8
- Buying at prices[4] = 4
- Selling at prices[5] = 9
The total profit is ((8 - 1) - 2) + ((9 - 4) - 2) = 8.

Example 2:

Input: prices = [1,3,7,5,10,3], fee = 3
Output: 6
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStockwithTransactionFee
{
    public class Solution
    {
        public static int MaxProfit(int[] prices, int fee)
        {
            int holding = -prices[0];
            int notHolding = 0;

            for (int day = 1; day < prices.Length; day++)
            {
                holding = Math.Max(holding, notHolding - prices[day]);
                notHolding = Math.Max(notHolding, holding + prices[day] - fee);
            }

            return Math.Max(holding, notHolding);
        }
    }

    public class Test
    {
        public static bool[] TestBestTimetoBuyandSellStockwithTransactionFee()
        {
            int[] prices1 = {1,3,2,8,4,9};
            int fee1 = 2;
            int[] prices2 = {1,3,7,5,10,3};
            int fee2 = 3;

            int result1 = Solution.MaxProfit(prices1, fee1);
            int result2 = Solution.MaxProfit(prices2, fee2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 8),
                ResultTester.CheckResult<int>(result2, 6),
            };

            return results;
        }
    }
}