// Range Sum Query 2D - Immutable

/*
Given a 2D matrix matrix, handle multiple queries of the following type:

Calculate the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
Implement the NumMatrix class:

NumMatrix(int[][] matrix) Initializes the object with the integer matrix matrix.
int sumRegion(int row1, int col1, int row2, int col2) Returns the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).
You must design an algorithm where sumRegion works on O(1) time complexity.


Example 1:

Input
["NumMatrix", "sumRegion", "sumRegion", "sumRegion"]
[[[[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]]], [2, 1, 4, 3], [1, 1, 2, 2], [1, 2, 2, 4]]
Output
[null, 8, 11, 12]

Explanation
NumMatrix numMatrix = new NumMatrix([[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]]);
numMatrix.sumRegion(2, 1, 4, 3); // return 8 (i.e sum of the red rectangle)
numMatrix.sumRegion(1, 1, 2, 2); // return 11 (i.e sum of the green rectangle)
numMatrix.sumRegion(1, 2, 2, 4); // return 12 (i.e sum of the blue rectangle)
*/

using System;
namespace CompetitiveProgramming.LeetCode.RangeSumQuery2DImmutable
{
    public class NumMatrix
    {
        private readonly int[,] dp;

        public NumMatrix(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            dp = new int[m, n + 1];
            for (int row = 0; row < m; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    dp[row, column + 1] += matrix[row][column] + dp[row, column];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int sum = 0;
            for (int row = row1; row <= row2; row++)
            {
                sum += dp[row, col2 + 1] - dp[row, col1];
            }

            return sum;
        }
    }

    /**
    * Your NumMatrix object will be instantiated and called as such:
    * NumMatrix obj = new NumMatrix(matrix);
    * int param_1 = obj.SumRegion(row1,col1,row2,col2);
    */
}