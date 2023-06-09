// Maximal Square

/*
Given an m x n binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.

 

Example 1:


Input: matrix = [["1","0","1","0","0"],["1","0","1","1","1"],["1","1","1","1","1"],["1","0","0","1","0"]]
Output: 4

Example 2:


Input: matrix = [["0","1"],["1","0"]]
Output: 1

Example 3:

Input: matrix = [["0"]]
Output: 0
*/

using System;
namespace CompetitiveProgramming.LeetCode.MaximalSquare
{
    public class Solution
    {
        // Top Down

        static int maxResult;
        static int[][]? dp;

        public static int MaximalSquare(char[][] matrix)
        {
            maxResult = 0;
            dp = new int[matrix.Length][];
            for(int i = 0; i < dp.Length; i++)
            {
                int[] arry = new int[matrix[0].Length];
                Array.Fill(arry, -1);
                dp[i] = arry;
            }

            FindMaxSquar(matrix, 0, 0);
            return maxResult * maxResult;
        }

        private static int FindMaxSquar(char[][] matrix, int i, int j)
        {
            if(i >= matrix.Length || j >= matrix[0].Length)
                return 0;
            
            if(dp![i][j] != -1)
                return dp![i][j];

            int right = FindMaxSquar(matrix, i, j+1);
            int diag  = FindMaxSquar(matrix, i+1, j+1);
            int below = FindMaxSquar(matrix, i+1, j);

            if(matrix[i][j] == '0')
            {
                return dp[i][j] = 0;
            }
            else
            {
                int localRes = 1 + Math.Min(right, Math.Min(diag, below));
                maxResult = Math.Max(maxResult, localRes);
                return dp[i][j] = localRes;
            }
        }
    }
}