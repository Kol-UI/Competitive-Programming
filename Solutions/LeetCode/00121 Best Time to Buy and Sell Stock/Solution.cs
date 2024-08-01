using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BestTimetoBuyandSellStock
{
	public class Solution
	{
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.

        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.


        //Example 1:

        //Input: prices = [7, 1, 5, 3, 6, 4]
        //Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

        //Example 2:

        //Input: prices = [7,6,4,3,1]
        //Output: 0
        //Explanation: In this case, no transactions are done and the max profit = 0.


        public static int MaxProfit(int[] prices)
        {
            var min = prices[0];
            var profit = 0;
            foreach (var day in prices)
            {
                profit = Math.Max(profit, day - min);
                min = Math.Min(min, day);
            }
            return profit;
        }
    }

    public class Test
    {
        public static bool[] TestBestTimetoBuyandSellStock()
        {
            // Case 1
            int[] pricesCase1_121 = { 7, 1, 5, 3, 6, 4 };
            int Case1_121_Result = Solution.MaxProfit(pricesCase1_121);

            // Case 2
            int[] pricesCase2_121 = { 7, 6, 4, 3, 1 };
            int Case2_121_Result = Solution.MaxProfit(pricesCase2_121);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_121_Result, 5),
                ResultTester.CheckResult<int>(Case2_121_Result, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Time to Buy and Sell Stock");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestBestTimetoBuyandSellStock());
        }
    }
}