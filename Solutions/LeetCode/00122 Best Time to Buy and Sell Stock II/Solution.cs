// Best Time to Buy and Sell Stock II

/*
You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.

Find and return the maximum profit you can achieve.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 7
Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
Total profit is 4 + 3 = 7.

Example 2:

Input: prices = [1,2,3,4,5]
Output: 4
Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
Total profit is 4.

Example 3:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: There is no way to make a positive profit, so we never buy the stock to achieve the maximum profit of 0.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStockII
{
    public class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int profit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i; j < prices.Length - 1; j++)
                {
                    if (prices[j] < prices[j + 1])
                        profit += (prices[j + 1] - prices[j]);
                }

                if (profit > maxProfit)
                    maxProfit = profit;

                profit = 0;
            }

            return maxProfit;
        }
    }

    public class Test
    {
        public static bool[] TestBestTimetoBuyandSellStockII()
        {
            int[] prices1_122 = {1,2,3,4,5};
            int[] prices2_122 = {7,6,4,3,1};

            int result1_122 = Solution.MaxProfit(prices1_122);
            int result2_122 = Solution.MaxProfit(prices2_122);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_122, 4),
                ResultTester.CheckResult<int>(result2_122, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestBestTimetoBuyandSellStockII());
        }
    }
}