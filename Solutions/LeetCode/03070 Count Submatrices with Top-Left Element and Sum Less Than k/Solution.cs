// Count Submatrices with Top-Left Element and Sum Less Than k
namespace CompetitiveProgramming.LeetCode.CountSubmatriceswithTopLeftElementandSumLessThank;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountSubmatrices(int[][] grid, int k)
    {
        var aux = CreateAuxMatrix(grid);
        var result = InitAux(aux, grid, k);
        for (int i = 1; i < aux.Length; i++)
        {
            for (int j = 1; j < aux[i].Length; j++)
            {
                aux[i][j] = grid[i][j] + aux[i - 1][j] + aux[i][j - 1] - aux[i - 1][j - 1];
                if (aux[i][j] <= k) result++;
            }
        }
        return result;
    }
    private int InitAux(int[][] aux, int[][] grid, int k)
    {
        var result = 0;
        aux[0][0] = grid[0][0];
        if (aux[0][0] <= k) result++;
        for (int i = 1; i < aux.Length; i++)
        {
            aux[i][0] = aux[i - 1][0] + grid[i][0];
            if (aux[i][0] <= k) result++;
        }
        for (int i = 1; i < aux[0].Length; i++)
        {
            aux[0][i] = aux[0][i - 1] + grid[0][i];
            if (aux[0][i] <= k) result++;
        }
        return result;
    }
    private int[][] CreateAuxMatrix(int[][] grid)
    {
        var result = new int[grid.Length][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new int[grid[i].Length];
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Submatrices with Top-Left Element and Sum Less Than k");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}