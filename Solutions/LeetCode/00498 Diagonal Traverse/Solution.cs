// Diagonal Traverse
namespace CompetitiveProgramming.LeetCode.DiagonalTraverse;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat) 
    {
        if (mat == null || mat.Length == 0 || mat[0].Length == 0) 
        {
            return new int[0];
        }

        int m = mat.Length;
        int n = mat[0].Length;

        int[] result = new int[m * n];
        int index = 0;

        for (int sum = 0; sum <= m + n - 2; sum++) 
        {
            if (sum % 2 == 0)
            {
                for (int row = Math.Min(sum, m - 1); row >= 0 && sum - row < n; row--) 
                {
                    result[index++] = mat[row][sum - row];
                }
            } 
            else 
            {
                for (int col = Math.Min(sum, n - 1); col >= 0 && sum - col < m; col--) 
                {
                    result[index++] = mat[sum - col][col];
                }
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[][] mat1 = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
        int[][] mat2 = new int[][]
        {
            new int[] {1, 2},
            new int[] {3, 4}
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[]>(solution.FindDiagonalOrder(mat1), new int[]{1,2,4,7,5,3,6,8,9}),
            ResultTester.CheckResult<int[]>(solution.FindDiagonalOrder(mat2), new int[]{1,2,3,4})
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Diagonal Traverse");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}