// Sell Diminishing-Valued Colored Balls

/*
You have an inventory of different colored balls, and there is a customer that wants orders balls of any color.

The customer weirdly values the colored balls. Each colored ball's value is the number of balls of that color you currently have in your inventory. For example, if you own 6 yellow balls, the customer would pay 6 for the first yellow ball. After the transaction, there are only 5 yellow balls left, so the next yellow ball is then valued at 5 (i.e., the value of the balls decreases as you sell more to the customer).

You are given an integer array, inventory, where inventory[i] represents the number of balls of the ith color that you initially own. You are also given an integer orders, which represents the total number of balls that the customer wants. You can sell the balls in any order.

Return the maximum total value that you can attain after selling orders colored balls. As the answer may be too large, return it modulo 109 + 7.

 

Example 1:

Input: inventory = [2,5], orders = 4
Output: 14
Explanation: Sell the 1st color 1 time (2) and the 2nd color 3 times (5 + 4 + 3).
The maximum total value is 2 + 5 + 4 + 3 = 14.

Example 2:

Input: inventory = [3,5], orders = 6
Output: 19
Explanation: Sell the 1st color 2 times (3 + 2) and the 2nd color 4 times (5 + 4 + 3 + 2).
The maximum total value is 3 + 2 + 5 + 4 + 3 + 2 = 19.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SellDiminishingValuedColoredBalls
{
    public class Solution
    {
        public static int MaxProfit(int[] inventory, int orders)
        {
            Array.Sort(inventory, (a,b) => b-a);
            int idx = 0; 
            long currPrice = inventory[0], nextPrice = 0, sell = 0, res = 0;
            
            while(orders > 0)
            {
                while(idx < inventory.Length && inventory[idx] == currPrice)
                    idx++;
                
                nextPrice = idx == inventory.Length? 0 : inventory[idx];
                
                sell = Math.Min(orders, idx * (currPrice - nextPrice));
                
                long priceDiff = currPrice - nextPrice;            
                int remainder = 0;
                
                if(orders < idx * (currPrice - nextPrice))
                {
                    priceDiff = orders / idx;
                    remainder = orders % idx;
                    nextPrice = currPrice - priceDiff;
                }              
                
                res = (res + (currPrice + nextPrice + 1) * priceDiff / 2 * idx + nextPrice * remainder) % 1000000007;
                orders -= (int)sell;
                currPrice = nextPrice;
            }
            
            return (int)res;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] inventory1 = {2,5};
            int orders1 = 4;
            int[] inventory2 = {3,5};
            int orders2 = 6;
            int result1 = Solution.MaxProfit(inventory1, orders1);
            int result2 = Solution.MaxProfit(inventory2, orders2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 14),
                ResultTester.CheckResult<int>(result2, 19)
            };
            return results;
        }
    }
}