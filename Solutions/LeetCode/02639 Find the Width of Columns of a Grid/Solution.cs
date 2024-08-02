// Find the Width of Columns of a Grid


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheWidthofColumnsofaGrid
{
    public class Solution 
    {
        public static int[] FindColumnWidth(int[][] grid) 
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int lenght = 0;
                for (int j = 0; j < m; j++)
                {
                    lenght = Math.Max(lenght, grid[j][i].ToString().Length);
                }
                result[i] = lenght;
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
                new int[] { 1 },
                new int[] { 22 },
                new int[] { 333 }
            };

            int[][] matrix2 = new int[][]
            {
                new int[] { -15, 1, 3 },
                new int[] { 15, 7, 12 },
                new int[] { 5, 6, -2 },
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindColumnWidth(matrix1), new int[]{3}),
                ResultTester.CheckResult<int[]>(Solution.FindColumnWidth(matrix2), new int[]{3,1,2}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2639");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}