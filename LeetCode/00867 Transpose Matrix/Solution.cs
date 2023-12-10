// Transpose Matrix



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.TransposeMatrix
{
    public class Solution
    {
        public static int[][] Transpose(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int[][] transposed = new int[cols][];
            
            for (int i = 0; i < cols; i++)
            {
                transposed[i] = new int[rows];

                for (int j = 0; j < rows; j++)
                {
                    transposed[i][j] = matrix[j][i];
                }
            }

            return transposed;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] matrix1 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };

            int[][] expectedOutput1 = new int[][]
            {
                new int[] {1, 4, 7},
                new int[] {2, 5, 8},
                new int[] {3, 6, 9}
            };

            int[][] matrix2 = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6}
            };

            int[][] expectedOutput2 = new int[][]
            {
                new int[] {1, 4},
                new int[] {2, 5},
                new int[] {3, 6}
            };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.Transpose(matrix1), expectedOutput1),
                ResultTester.CheckResult<int[][]>(Solution.Transpose(matrix2), expectedOutput2),
            };
            return results;
        }
    }
}