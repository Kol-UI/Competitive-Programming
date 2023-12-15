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
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestMatrixBlockSum()
        {
            int[][] matrix1_1314 = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7,8,9 }
            };
            int k1_1314 = 1;
            int[][] matrix2_1314 = new int[][]
            {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7,8,9 }
            };
            int k2_1314 = 2;

            int[][] result1 = Solution.MatrixBlockSum(matrix1_1314, k1_1314);
            int[][] result2 = Solution.MatrixBlockSum(matrix2_1314, k2_1314);

            int[][] matrixOutput1 = new int[][]
            {
                new int[] { 12,21,16 },
                new int[] { 27,45,33 },
                new int[] { 24,39,28 }
            };

            int[][] matrixOutput2 = new int[][]
            {
                new int[] { 45,45,45 },
                new int[] { 45,45,45 },
                new int[] { 45,45,45 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(result1, matrixOutput1),
                ResultTester.CheckResult<int[][]>(result2, matrixOutput2)
            };
            return results;
        }
    }
}
