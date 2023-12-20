// Buy Two Chocolates



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.BuyTwoChocolates
{
    public class Solution
    {
        public static int BuyChoco(int[] prices, int money)
        {
            int minIndex = GetMinimumIndex(prices);
            
            int minCost = prices[minIndex];
            prices[minIndex] = int.MaxValue;
            
            int secondMinIndex = GetMinimumIndex(prices);
            int secondMinCost = prices[secondMinIndex];
            
            minCost += secondMinCost;

            if (minCost <= money)
            {
                return money - minCost;
            }
            else
            {
                return money;
            }
        }

        private static int GetMinimumIndex(int[] arr)
        {
            int min = arr[0];
            int minIndex = 0;
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            
            return minIndex;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] prices1 = new int[]{1,2,2};
            int money1 = 3;

            int[] prices2 = new int[]{3,2,3};
            int money2 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.BuyChoco(prices1, money1), 0),
                ResultTester.CheckResult<int>(Solution.BuyChoco(prices2, money2), 3),
            };
            return results;
        }
    }
}