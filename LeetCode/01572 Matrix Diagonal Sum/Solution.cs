// Matrix Diagonal Sum

/*
Given a square matrix mat, return the sum of the matrix diagonals.

Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

 

Example 1:

Input: mat = [[1,2,3],
              [4,5,6],
              [7,8,9]]
Output: 25
Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
Notice that element mat[1][1] = 5 is counted only once.

Example 2:

Input: mat = [[1,1,1,1],
              [1,1,1,1],
              [1,1,1,1],
              [1,1,1,1]]
Output: 8

Example 3:

Input: mat = [[5]]
Output: 5
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MatrixDiagonalSum
{
    public class Solution
    {
        public static int DiagonalSum(int[][] mat)
        {
            int n = mat.Length;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int size = mat[i].Length;
                for (int j = 0; j < size; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        sum += mat[i][j];
                    }
                }
            }
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[][] grid1_1572 = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7,8,9 }
            };
            int result1 = Solution.DiagonalSum(grid1_1572);

            // Case 2
            int[][] grid2_1572 = new int[][]
            {
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 },
                new int[] { 1,1,1,1 }
            };
            int result2 = Solution.DiagonalSum(grid2_1572);

            // Case 3
            int[][] grid3_1572 = new int[][]
            {
                new int[] { 5 }
            };
            int result3 = Solution.DiagonalSum(grid3_1572);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 25),
                ResultTester.CheckResult<int>(result2, 8),
                ResultTester.CheckResult<int>(result3, 5)
            };
            return results;
        }
    }
}