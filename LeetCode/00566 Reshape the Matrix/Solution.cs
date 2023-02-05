using System;

namespace CompetitiveProgramming.LeetCode.ReshapetheMatrix
{
    // In MATLAB, there is a handy function called reshape which can reshape an m x n matrix into a new one with a different size r x c keeping its original data.

    // You are given an m x n matrix mat and two integers r and c representing the number of rows and the number of columns of the wanted reshaped matrix.

    // The reshaped matrix should be filled with all the elements of the original matrix in the same row-traversing order as they were.

    // If the reshape operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.

    // Example 1:
    // Input: mat = [[1,2],[3,4]], r = 1, c = 4
    // Output: [[1,2,3,4]]

    // Example 2:
    // Input: mat = [[1,2],[3,4]], r = 2, c = 4
    // Output: [[1,2],[3,4]]
    public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int col = mat.Length;
        int row = mat[0].Length;

        if (row * col != r * c) return mat;

        int[][] res = new int[r][];

        for (int i = 0; i < r; i++)
        {
            res[i] = new int[c];
        }

        int outCol = 0;
        int outRow = 0;

        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (outCol < r && outRow < c)
                {
                    res[outCol][outRow++] = mat[i][j];
                }
                else
                {
                    outRow = 0;
                    res[++outCol][outRow++] = mat[i][j];
                }
            }
        }
        return res;
    }
}
}


