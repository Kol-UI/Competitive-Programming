// Count Submatrices With All Ones
namespace CompetitiveProgramming.LeetCode.CountSubmatricesWithAllOnes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumSubmat(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        int[,] height = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 1)
                {
                    height[i, j] = (i == 0) ? 1 : height[i - 1, j] + 1;
                }
            }
        }

        int count = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int minHeight = int.MaxValue;
                for (int k = j; k >= 0; k--)
                {
                    minHeight = Math.Min(minHeight, height[i, k]);
                    if (minHeight == 0) break;
                    count += minHeight;
                }
            }
        }

        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();

        int[][] mat1 = new int[][]
        {
            new int[] { 1, 0, 1 },
            new int[] { 1, 1, 0 },
            new int[] { 1, 1, 0 }
        };

        int[][] mat2 = new int[][]
        {
            new int[] { 0, 1, 1, 0 },
            new int[] { 0, 1, 1, 1 },
            new int[] { 1, 1, 1, 0 }
        };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumSubmat(mat1), 13),
            ResultTester.CheckResult<int>(solution.NumSubmat(mat2), 24)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Submatrices With All Ones");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}