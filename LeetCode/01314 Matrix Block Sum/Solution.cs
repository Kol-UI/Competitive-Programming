// Matrix Block Sum

/*
Given a m x n matrix mat and an integer k, return a matrix answer where each answer[i][j] is the sum of all elements mat[r][c] for:

i - k <= r <= i + k,
j - k <= c <= j + k, and
(r, c) is a valid position in the matrix.
 

Example 1:

Input: mat = [[1,2,3],[4,5,6],[7,8,9]], k = 1
Output: [[12,21,16],[27,45,33],[24,39,28]]

Example 2:

Input: mat = [[1,2,3],[4,5,6],[7,8,9]], k = 2
Output: [[45,45,45],[45,45,45],[45,45,45]]
*/

using System;
namespace CompetitiveProgramming.LeetCode.MatrixBlockSum
{
    public class Solution
    {
        public static int[][] MatrixBlockSum(int[][] mat, int k)
        {
            var rs = new int[mat.Length][];

            for (int i = 0; i < rs.Length; i++)
                rs[i] = new int[mat[i].Length];

            var initValue = GetInitValue(mat, k);

            for (int i = 0; i < rs.Length; i++)
            {
                if (0 < i) initValue = GetNextRowValue(initValue, i, k, mat);
                
                var value = initValue;

                for (int j = 0; j < rs[i].Length; j++)
                {
                    rs[i][j] = value;
                    if (j < rs[i].Length - 1) value = GetNextColValue(value, i, j + 1, k, mat);
                }
            }
            return rs;
        }

        private static int GetNextRowValue(int initValue, int row, int k, int[][] mat)
        {
            var rs = initValue;
            for (int i = -k; i <= k; i++)
            {
                rs -= GetItem(row - k - 1, i, mat);
                rs += GetItem(row + k, i, mat);
            }
            return rs;
        }
        private static int GetNextColValue(int value, int row, int col, int k, int[][] mat)
        {
            var rs = value;
            for (int i = -k; i <= k; i++)
            {
                rs -= GetItem(row + i, col - k - 1, mat);
                rs += GetItem(row + i, col + k, mat);
            }
            return rs;
        }
        private static int GetInitValue(int[][] mat, int k)
        {
            var rs = 0;
            for (int i = 0; i <= Math.Min(k, mat.Length - 1); i++)
            {
                for (int j = 0; j <= Math.Min(k, mat[i].Length - 1); j++)
                {
                    rs += mat[i][j];
                }
            }
            return rs;
        }
        private static int GetItem(int row, int col, int[][] arr)
        {
            if (0 <= row && row < arr.Length && 0 <= col && col < arr[row].Length)
            {
                return arr[row][col];
            }
            return 0;
        }
    }
}
