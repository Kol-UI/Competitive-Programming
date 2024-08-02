// Modify the Matrix


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ModifytheMatrix
{
    public class Solution
    {
        public static int[][] ModifiedMatrix(int[][] matrix)
        {
            var result = Helper(matrix);
            for (int j = 0; j < matrix[0].Length; j++)
            {
                var max = matrix[0][j];
                for (int i = 1; i < matrix.Length; i++)
                {
                    max = Math.Max(max, matrix[i][j]);
                }
                for (int i = 0; i < matrix.Length; i++)
                {
                    result[i][j] = matrix[i][j] == -1 ? max : matrix[i][j];
                }
            }
            return result;
        }
        
        private static int[][] Helper(int[][] matrix)
        {
            var result = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new int[matrix[i].Length];
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
                new int[] {1,2,-1},
                new int[] {4,-1,6},
                new int[] {7,8,9}
            };

            int[][] result1 = new int[][]
            {
                new int[] {1,2,9},
                new int[] {4,8,6},
                new int[] {7,8,9}
            };

            int[][] matrix2 = new int[][]
            {
                new int[] {3,-1},
                new int[] {5,2}
            };

            int[][] result2 = new int[][]
            {
                new int[] {3,2},
                new int[] {5,2}
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.ModifiedMatrix(matrix1), result1),
                ResultTester.CheckResult<int[][]>(Solution.ModifiedMatrix(matrix2), result2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("3033");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}