// Set Matrix Zeroes

/*
Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.

You must do it in place.

 

Example 1:

Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]

Example 2:


Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
*/


using System;
namespace CompetitiveProgramming.LeetCode.SetMatrixZeroes
{
    public class Solution
    {
        public static void SetZeroes(int[][] matrix)
        {
            var rows = new HashSet<int>();
            var cols = new HashSet<int>();

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }

            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[0].Length; j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                        matrix[i][j] = 0;
                }
            }
        }
    }
}