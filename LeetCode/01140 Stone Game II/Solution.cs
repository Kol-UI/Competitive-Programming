// Stone Game II

/*
Alice and Bob continue their games with piles of stones.  There are a number of piles arranged in a row, and each pile has a positive integer number of stones piles[i].  The objective of the game is to end with the most stones. 
Alice and Bob take turns, with Alice starting first.  Initially, M = 1.
On each player's turn, that player can take all the stones in the first X remaining piles, where 1 <= X <= 2M.  Then, we set M = max(M, X).
The game continues until all the stones have been taken.
Assuming Alice and Bob play optimally, return the maximum number of stones Alice can get.


Example 1:

Input: piles = [2,7,9,4,4]
Output: 10
Explanation:  If Alice takes one pile at the beginning, Bob takes two piles, then Alice takes 2 piles again. Alice can get 2 + 4 + 4 = 10 piles in total. If Alice takes two piles at the beginning, then Bob can take all three piles left. In this case, Alice get 2 + 7 = 9 piles in total. So we return 10 since it's larger. 

Example 2:

Input: piles = [1,2,3,4,5,100]
Output: 104
*/

using System;
namespace CompetitiveProgramming.LeetCode.StoneGameII
{
    public class Solution
    {
        public static int StoneGameII(int[] piles)
        {
            int n = piles.Length;
            int[,] dp = new int[n,n];
            int[] sums = new int[n];
            sums[n-1] = piles[n-1];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    dp[i,j] = -1;
                }
            }

            for(int i = piles.Length - 2; i >= 0; i--)
            {
                sums[i] = sums[i+1] + piles[i];
            }

            return DFS(piles, sums, dp, 0, 1);
        }

        private static int DFS(int[] piles, int[] sums, int[,] dp, int i, int M)
        {
            if(i == piles.Length) return 0;

            int twiceM = (M << 1);

            if(i + twiceM >= piles.Length) return sums[i];
            
            if(dp[i, M] != -1) return dp[i, M];

            int min = int.MaxValue;

            for(int j = 1; j <= twiceM; j++)
            {
                min = Math.Min(min, DFS(piles, sums, dp, i+j, Math.Max(j, M)));
            }

            return dp[i, M] = sums[i] - min;
        }
    }
}
