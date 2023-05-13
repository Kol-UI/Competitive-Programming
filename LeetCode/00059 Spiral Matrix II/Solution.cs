// Spiral Matrix II

/*
Given a positive integer n, generate an n x n matrix filled with elements from 1 to n2 in spiral order.

 

Example 1:

Input: n = 3
Output: [[1,2,3],[8,9,4],[7,6,5]]

Example 2:

Input: n = 1
Output: [[1]]
*/

using System;
namespace CompetitiveProgramming.LeetCode.SpiralMatrixII
{
    public class Solution
    {
        public static int[][] GenerateMatrix(int n)
        {
            int num = 1;
            int[][] result = new int[n][];

            for (int i = 0; i < n; i++) result[i] = new int[n];

            for (int i = 0, j = n - 1; i <= j; i++, j--)
            {
                for (int k = i; k <= j; k++) result[i][k] = num++;
                for (int k = i + 1; k <= j; k++) result[k][j] = num++;
                for (int k = j - 1; k >= i; k--) result[j][k] = num++;
                for (int k = j - 1; k > i; k--) result[k][i] = num++;
            }
            return result;
        }
    }
}