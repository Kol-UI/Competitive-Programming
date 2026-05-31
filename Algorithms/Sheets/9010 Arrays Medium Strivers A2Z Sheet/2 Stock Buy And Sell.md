Problem Statement: You are given an array of prices where prices[i] is the price of a given stock on an ith day.


You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.


Examples :


Example 1:

Input: prices = [7,1,5,3,6,4]

Output: 5

Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.

Note: That buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.


Example 2:

Input: prices = [7,6,4,3,1]

Output: 0

Explanation: In this case, no transactions are done and the max profit = 0.


```cs
public class StockBuyAndSell
{
    public int MaxProfit(int[] nums)
    {
        if (nums == null || nums.Length < 2) return 0;

        int minPrice = nums[0];
        int maxProfit = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            int currentProfit = nums[i] - minPrice;
            maxProfit = Math.Max(maxProfit, currentProfit);
            minPrice = Math.Min(minPrice, nums[i]);
        }

        return maxProfit;
    }
}
```


```cs
public int MaxProfit(int[] nums)
{
	if (nums == null || nums.Length < 2) return 0;

	int minPrice = nums[0];
	int maxProfit = 0;

	for (int i = 1; i < nums.Length; i++)
	{
		// Calculate the potential profit if we were to sell on the current day (nums[i]),
		// having bought at the 'minPrice' recorded so far.
		int currentProfit = nums[i] - minPrice;
		
		// Update maxProfit: We want to ensure 'maxProfit' always holds
		// the highest profit achieved. So, we compare the current potential profit
		// with our existing 'maxProfit' and keep the larger one.
		maxProfit = Math.Max(maxProfit, currentProfit);
		
		// Update minPrice:
		// If the current day's price (nums[i]) is lower than our recorded 'minPrice',
		// then this new lower price becomes our new 'minPrice' for subsequent days.
		// It's placed after 'maxProfit' update because we use the 'minPrice'
		// from before today to calculate today's potential profit.
		minPrice = Math.Min(minPrice, nums[i]);
	}
	
	return maxProfit;
}
```