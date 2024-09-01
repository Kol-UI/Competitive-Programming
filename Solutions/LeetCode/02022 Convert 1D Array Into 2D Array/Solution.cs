// Convert 1D Array Into 2D Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Convert1DArrayInto2DArray
{
    public class Solution
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (original.Length != m * n)
                return new int[0][];

            int[][] result = new int[m][];
            Fill2DArray(original, result, m, n);
            return result;
        }

        private static void Fill2DArray(int[] original, int[][] result, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    result[i][j] = original[i * n + j];
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            int[] original1 = { 1, 2, 3, 4 };
            int m1 = 2, n1 = 2;
            int[][] expected1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };

            int[] original2 = { 1, 2, 3 };
            int m2 = 1, n2 = 3;
            int[][] expected2 = new int[][]
            {
                new int[] { 1, 2, 3 }
            };

            int[] original3 = { 1, 2 };
            int m3 = 1, n3 = 1;
            int[][] expected3 = new int[0][];

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(solution.Construct2DArray(original1, m1, n1), expected1),
                ResultTester.CheckResult<int[][]>(solution.Construct2DArray(original2, m2, n2), expected2),
                ResultTester.CheckResult<int[][]>(solution.Construct2DArray(original3, m3, n3), expected3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert 1D Array Into 2D Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}