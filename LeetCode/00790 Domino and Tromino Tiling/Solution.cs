// Domino and Tromino Tiling

/*
You have two types of tiles: a 2 x 1 domino shape and a tromino shape. You may rotate these shapes.


Given an integer n, return the number of ways to tile an 2 x n board. Since the answer may be very large, return it modulo 109 + 7.

In a tiling, every square must be covered by a tile. Two tilings are different if and only if there are two 4-directionally adjacent cells on the board such that exactly one of the tilings has both squares occupied by a tile.

 

Example 1:

Input: n = 3
Output: 5
Explanation: The five different ways are show above.

Example 2:

Input: n = 1
Output: 1
*/

using System;
namespace CompetitiveProgramming.LeetCode.DominoandTrominoTiling
{
    public class Solution
    {
        public static int NumTilings(int n)
        {
            if (n is 1 or 2) return n;

            long mod = 1_000_000_007;
            long prev = 2;
            long prev2 = 1;
            long sum = 0;
            long result = 0;
            int i = 3;

            while (i <= n)
            {
                result = (prev + prev2 + 2 * (sum + 1)) % mod;
                sum = (sum + prev2) % mod;
                (prev2, prev) = (prev, result);
                i++;
            }
            return (int)result;
        }
    }
}