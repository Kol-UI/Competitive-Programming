using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumIceCreamBars
{
    public class Solution
    {
        //It is a sweltering summer day, and a boy wants to buy some ice cream bars.
        //At the store, there are n ice cream bars.
        //You are given an array costs of length n, where costs[i] is the price of the ith ice cream bar in coins.
        //The boy initially has coins coins to spend, and he wants to buy as many ice cream bars as possible.
        //Return the maximum number of ice cream bars the boy can buy with coins coins.
        //Note: The boy can buy the ice cream bars in any order.

        //Example 1:
        //Input: costs = [1, 3, 2, 4, 1], coins = 7
        //Output: 4
        //Explanation: The boy can buy ice cream bars at indices 0,1,2,4 for a total price of 1 + 3 + 2 + 1 = 7.

        //Example 2:
        //Input: costs = [10, 6, 8, 7, 7, 8], coins = 5
        //Output: 0
        //Explanation: The boy cannot afford any of the ice cream bars.

        //Example 3:
        //Input: costs = [1, 6, 3, 1, 2, 5], coins = 20
        //Output: 6
        //Explanation: The boy can buy all the ice cream bars for a total price of 1 + 6 + 3 + 1 + 2 + 5 = 18.

        public static int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);
            var count = 0;
            foreach (var cost in costs)
            {
                if (coins >= cost)
                {
                    count++;
                    coins -= cost;
                }
                else break;
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] Case1_1833 = { 1, 2, 3, 1 };
            int CoinsCase1 = 7;
            int Case1_1833_Result = Solution.MaxIceCream(Case1_1833, CoinsCase1);

            // Case 2
            int[] Case2_1833 = { 10, 6, 8, 7, 7, 8 };
            int CoinsCase2 = 5;
            int Case2_1833_Result = Solution.MaxIceCream(Case2_1833, CoinsCase2);

            // Case 3
            int[] Case3_1833 = { 1, 6, 3, 1, 2, 5 };
            int CoinsCase3 = 20;
            int Case3_1833_Result = Solution.MaxIceCream(Case3_1833, CoinsCase3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1833_Result, 4),
                ResultTester.CheckResult<int>(Case2_1833_Result, 0),
                ResultTester.CheckResult<int>(Case3_1833_Result, 6)
            };
            return results;
        }
    }
}

