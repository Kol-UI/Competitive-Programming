You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

On each day, you may decide to buy and/or sell the stock.

However, you can buy it then immediately sell it on the same day.
Also, you are allowed to perform any number of transactions but can hold at most one share of the stock at any time.

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



Greedy

```cs
public class BestTimetoBuyandSellStockIIGreedy
{
    // Called Greedy because it always makes the decision that seems best immediately, without worrying about the long-term consequences
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        // Starts from second day because we compare prices between yesterday & today
        for (int i = 1; i < prices.Length; i++)
        {
            // If today's price is higher than yesterday, then there was a rise
            if (prices[i] > prices[i - 1])
            {
                // Profit done, also loop is not over so we can buy again
                profit += prices[i] - prices[i - 1];
            }
        }
        return profit;
    }
}
```


Recursion
```cs
public class BestTimetoBuyandSellStockIIRecursion()
{
    public int MaxProfit(int[] prices)
    {
        return MakeProfit(prices, 0, false);
    }

    private int MakeProfit(int[] prices, int i, bool bought)
    {
        if (i == prices.Length) return 0;

        // Don't buy nor sell
        int result = MakeProfit(prices, i + 1, bought);

        if (bought) // If I already bought
        {
            // Then we found the hightest profit between "do nothing" and "sell"
            result = Math.Max(result, prices[i] + MakeProfit(prices, i + 1, false));
        }
        else // Otherwise if I didn't bought
        {
            // Then we found the highest profit between "do nothing" and "buy"
            result = Math.Max(result, -prices[i] + MakeProfit(prices, i + 1, true));
        }

        return result;
    }
}
```


Dynamic Programming - Top Down
```cs
public class BestTimetoBuyandSellStockIIDPTopDown
{
    public int MaxProfit(int[] prices)
    {
        int n = prices.Length;
        // Create a 'dp' table to store results that have already been calculated.
        // 'dp[i, 0]' will store the max profit at day 'i' if we DO NOT have a stock.
        // 'dp[i, 1]' will store the max profit at day 'i' if we DO have a stock.
        int[,] dp = new int[n, 2];

        // Initialize the 'dp' table with -1 to signify that no result has been calculated yet.
        // (-1 is a good choice because profit will never be negative in this problem.)
        for (int i = 0; i < n; i++)
        {
            dp[i, 0] = -1; // No profit calculated for day 'i' without a stock
            dp[i, 1] = -1; // No profit calculated for day 'i' with a stock
        }

        // Start the recursive function from day 0, with no stock (state 0),
        // and pass the 'dp' table for memoization.
        return MakeProfit(prices, 0, 0, dp);
    }

    private int MakeProfit(int[] prices, int i, int bought, int[,] dp)
    {
        if (i == prices.Length) return 0;

        // MEMOIZATION: max profit already found for this "i" day and "bought" state
        // So return the stored result directly
        if (dp[i, bought] != -1)
        {
            return dp[i, bought];
        }

        // SCENARIO 1: Do nothing today
        // The profit will be the same as if we move to the next day with the same current state (bought or not bought)
        int result = MakeProfit(prices, i + 1, bought, dp);

        // 'bought' parameter: 1 => currently holding a stock, 0 => currently not holding a stock

        // SCENARIO 2: Perform a transaction today
        if (bought == 1) // If I already have a stock (bought = 1)
        {
            // Sell or do noting
            result = Math.Max(result, prices[i] + MakeProfit(prices, i + 1, 0, dp));
        }
        else // Otherwise, I don't have a stock
        {
            // Buy or do nothing
            result = Math.Max(result, -prices[i] + MakeProfit(prices, i + 1, 1, dp));
        }

        // Stored to avoid recalculatin if counter again
        dp[i, bought] = result;
        return result; // Maximum profit for sub-problem
    }
}
```


Dynamic Programming - Bottom Up
```cs
public class BestTimetoBuyandSellStockIIRecursionDPBottomUp
{
    public int MaxProfit(int[] prices)
    {
        int n = prices.Length;
        // 'dp[i][1]' will store max profit at day 'i' if we do have a stock
        // We use 'n + 1' rows because 'i + 1' might go up to 'n' (representing the day after the last real day, with 0 profit)
        int[,] dp = new int[n + 1, 2];

        // Loop backwards from the last actual day ('n - 1') down to the first day (0)
        for (int i = n - 1; i >= 0; i--)
        {
            // Calculate max profit for day 'i' if we DON'T have a stock (dp[i, 0])
            dp[i, 0] = Math.Max(dp[i + 1, 0], -prices[i] + dp[i + 1, 1]);

            // Calculate max profit for day 'i' if we DO have a stock (dp[i, 1])
            dp[i, 1] = Math.Max(dp[i + 1, 1], prices[i] + dp[i + 1, 0]);
        }

        // The final answer is the maximum profit at day 0, when we initially don't have any stock
        return dp[0, 0];
    }
}
```


Dynamic Programming - Bottom Up - Space Optimize
```cs
public class BestTimetoBuyandSellStockIIRecursionDPSpaceOptimize
{
    // Bottom Up by Optimized
    // To calculate the maximum profit for the current day, we only need the maximum profits from the next day.
    // We don't need the entire dp table.
    public int MaxProfit(int[] prices)
    {
        int nextBuy = 0, nextSell = 0;
        int curBuy = 0, curSell = 0;

        for (int i = prices.Length - 1; i >= 0; i--)
        {
            curBuy = Math.Max(nextBuy, -prices[i] + nextSell);
            curSell = Math.Max(nextSell, prices[i] + nextBuy);
            nextBuy = curBuy;
            nextSell = curSell;
        }

        return curBuy;
    }
}
```