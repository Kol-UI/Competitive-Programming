// Largest Submatrix With Rearrangements


/*
You are given a binary matrix matrix of size m x n, and you are allowed to rearrange the columns of the matrix in any order.

Return the area of the largest submatrix within matrix where every element of the submatrix is 1 after reordering the columns optimally.

 

Example 1:


Input: matrix = [[0,0,1],[1,1,1],[1,0,1]]
Output: 4
Explanation: You can rearrange the columns as shown above.
The largest submatrix of 1s, in bold, has an area of 4.

Example 2:


Input: matrix = [[1,0,1,0,1]]
Output: 3
Explanation: You can rearrange the columns as shown above.
The largest submatrix of 1s, in bold, has an area of 3.

Example 3:

Input: matrix = [[1,1,0],[1,0,1]]
Output: 2
Explanation: Notice that you must rearrange entire columns, and there is no way to make a submatrix of 1s larger than an area of 2.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LargestSubmatrixWithRearrangements
{
    public class Solution
    {
        public static int LargestSubmatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int result = 0;

            for(int j = 0; j < cols; j++)
            {
                for(int i = 1; i < rows; i++)
                {
                    if(matrix[i][j] > 0 && matrix[i-1][j] > 0)
                    {
                        matrix[i][j] = 1 + matrix[i-1][j];
                    }
                }
            }

            for(int i = 0; i < rows; i++)
            {
                Array.Sort(matrix[i], (a, b) =>  b - a);
            }

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    result = Math.Max(result, (j + 1) * matrix[i][j]);
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 0, 0, 1 },
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 0, 1, 0, 1 },
            };

            int[][] matrix3 = new int[][]
            {
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LargestSubmatrix(matrix1), 4),
                ResultTester.CheckResult<int>(Solution.LargestSubmatrix(matrix2), 3),
                ResultTester.CheckResult<int>(Solution.LargestSubmatrix(matrix3), 2),
            };
            return results;
        }
    }
}