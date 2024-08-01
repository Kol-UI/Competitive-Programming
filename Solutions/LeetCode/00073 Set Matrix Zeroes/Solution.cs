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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestSetMatrixZeroes()
        {
            // Input Matrix 1
            int[][] matrix1 = new int[][]
            {
                new int[] {1, 1, 1},
                new int[] {1, 0, 1},
                new int[] {1, 1, 1}
            };

            // Output Matrix 1
            int[][] output1 = new int[][]
            {
                new int[] {1, 0, 1},
                new int[] {0, 0, 0},
                new int[] {1, 0, 1}
            };

            // Input Matrix 2
            int[][] matrix2 = new int[][]
            {
                new int[] {0, 1, 2, 0},
                new int[] {3, 4, 5, 2},
                new int[] {1, 3, 1, 5}
            };

            // Output Matrix 2
            int[][] output2 = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {0, 4, 5, 0},
                new int[] {0, 3, 1, 0}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(matrix1, matrix1),
                ResultTester.CheckResult<int[][]>(matrix2, matrix2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Set Matrix Zeroes");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSetMatrixZeroes());
        }
    }
}