// Maximum Value of K Coins From Piles

/*
There are n piles of coins on a table. Each pile consists of a positive number of coins of assorted denominations.

In one move, you can choose any coin on top of any pile, remove it, and add it to your wallet.

Given a list piles, where piles[i] is a list of integers denoting the composition of the ith pile from top to bottom, and a positive integer k, return the maximum total value of coins you can have in your wallet if you choose exactly k coins optimally.

Example 1:
Input: piles = [[1,100,3],[7,8,9]], k = 2
Output: 101
Explanation:
The above diagram shows the different ways we can choose k coins.
The maximum total we can obtain is 101.

Example 2:
Input: piles = [[100],[100],[100],[100],[100],[100],[1,1,1,1,1,1,700]], k = 7
Output: 706
Explanation:
The maximum total can be obtained if we choose all coins from the last pile.
 
*/

using System;
namespace CompetitiveProgramming.LeetCode.MaximumValueofKCoinsFromPiles
{
    public class Solution
    {
        public static int MaxValueOfCoins(IList<IList<int>> piles, int k)
        {
            int n = piles.Count;
            int[][] memo = new int[n + 1][];

            for (int i = 0; i <= n; i++)
            {
                memo[i] = new int[k + 1];
                Array.Fill(memo[i], -1);
            }

            return DP(piles, memo, 0, k);
        }

        public static int DP(IList<IList<int>> piles, int[][] memo, int i, int k)
        {
            if (k == 0 || i == piles.Count)
            {
                return 0;
            }
            if (memo[i][k] != -1)
            {
                return memo[i][k];
            }

            int res = DP(piles, memo, i + 1, k);
            int cur = 0;

            for (int j = 0; j < Math.Min(piles[i].Count, k); ++j)
            {
                cur += piles[i][j];
                res = Math.Max(res, cur + DP(piles, memo, i + 1, k - j - 1));
            }
            
            return memo[i][k] = res;
        }
    }
}