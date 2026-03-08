
Best Time to Buy and Sell Stock



You are given an integer array prices where prices[i] is the price of NeetCoin on the ith day.

You may choose a single day to buy one NeetCoin and choose a different day in the future to sell it.

Return the maximum profit you can achieve. You may choose to not make any transactions, in which case the profit would be 0.


Example 1:

Input: prices = [10,1,5,6,7,1]

Output: 6

Explanation: Buy prices[1] and sell prices[4], profit = 7 - 1 = 6.


Example 2:

Input: prices = [10,8,7,5,2]

Output: 0

Explanation: No profitable transactions can be made, thus the max profit is 0.



```cs

// Brute Force Approach
public class BestTimetoBuyandSellStockBruteForce
{
    // Step 1: Initialize the maximum profit to 0.
    // Step 2: Iterate through each price as a potential buying price.
    // Step 3: Iterate through all subsequent prices as potential selling prices.
    // Step 4: Calculate the profit and update the maximum profit if the current one is higher.
    // Step 5: Return the overall maximum profit found.
    public int MaxProfit(int[] prices)
    {
        int result = 0; // Global max profit

        for (int i = 0; i < prices.Length; i++)
        {
            int buy = prices[i]; // Current buying day
            for (int j = i + 1; j < prices.Length; j++)
            {
                int sell = prices[j]; // Potential selling day
                // Update result if the current transaction is better
                result = Math.Max(result, sell - buy);
            }
        }
        return result;
    }
}

/*
[7, 1, 5, 3]

i=0 (Buy: 7) -> j=1 (Sell: 1, P: -6), j=2 (Sell: 5, P: -2), j=3 (Sell: 3, P: -4)    | Max: 0
i=1 (Buy: 1) -> j=2 (Sell: 5, P: 4), j=3 (Sell: 3, P: 2)                            | Max: 4
i=2 (Buy: 5) -> j=3 (Sell: 3, P: -2)                                                | Max: 4
                                                                                    Final Result: 4
*/

// Two Pointers / Sliding Window Approach
public class BestTimetoBuyandSellStockTwoPointers
{
    // Step 1: Initialize 'left' at day 0 (buy) and 'right' at day 1 (sell).
    // Step 2: Loop until the 'right' pointer reaches the end of the array.
    // Step 3: If the price at 'left' is lower than at 'right', calculate profit and update max.
    // Step 4: If price at 'right' is lower than 'left', move the 'left' pointer to 'right' (found a cheaper buy day).
    // Step 5: Increment 'right' to check the next potential selling day.
    public int MaxProfit(int[] prices)
    {
        int left = 0; // Buy pointer
        int right = 1; // Sell pointer
        int maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                // Found a new minimum price, move buy pointer here
                left = right;
            }
            right++; // Always move sell pointer forward
        }
        return maxProfit;
    }
}

/*
[7, 1, 5, 3, 6, 4]

L=0 (7), R=1 (1) -> 7 > 1, so L = R = 1. Max: 0
L=1 (1), R=2 (5) -> 1 < 5, Profit: 4. Max: 4
L=1 (1), R=3 (3) -> 1 < 3, Profit: 2. Max: 4
L=1 (1), R=4 (6) -> 1 < 6, Profit: 5. Max: 5
L=1 (1), R=5 (4) -> 1 < 4, Profit: 3. Max: 5
                                    Final Result: 5
*/

// Dynamic Programming Approach (One Pass)
public class BestTimetoBuyandSellStockDynamicProgramming
{
    // Step 1: Initialize maxProfit to 0 and minBuy to the first day's price.
    // Step 2: Iterate through each price in the array (acting as the current selling day).
    // Step 3: Update the maxProfit by comparing it with (current price - minBuy).
    // Step 4: Update the minBuy if the current price is lower than our previous minimum.
    // Step 5: Return the maxProfit.
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minBuy = prices[0];

        foreach (int sell in prices)
        {
            // Update profit based on the lowest price seen so far
            maxProfit = Math.Max(maxProfit, sell - minBuy);
            // Update the lowest price seen so far
            minBuy = Math.Min(minBuy, sell);
        }
        return maxProfit;
    }
}

/*
[7, 1, 5, 3, 6, 4]

Day 1: Sell: 7 | MinBuy: 7 | Profit: 0-0 = 0 | Max: 0
Day 2: Sell: 1 | MinBuy: 1 | Profit: 1-1 = 0 | Max: 0
Day 3: Sell: 5 | MinBuy: 1 | Profit: 5-1 = 4 | Max: 4
Day 4: Sell: 3 | MinBuy: 1 | Profit: 3-1 = 2 | Max: 4
Day 5: Sell: 6 | MinBuy: 1 | Profit: 6-1 = 5 | Max: 5
Day 6: Sell: 4 | MinBuy: 1 | Profit: 4-1 = 3 | Max: 5
                                            Final Result: 5
*/


```
