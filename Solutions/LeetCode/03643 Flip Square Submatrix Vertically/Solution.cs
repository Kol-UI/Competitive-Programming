// Flip Square Submatrix Vertically
namespace CompetitiveProgramming.LeetCode.FlipSquareSubmatrixVertically;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
    {
        for (int row = x; row < x + k / 2; row++)
        {
            for (int i = 0; i < k; i++)
            {
                var aux = grid[row][y + i];
                var shift = row - x;
                grid[row][y + i] = grid[x + k - 1 - shift][y + i];
                grid[x + k - 1 - shift][y + i] = aux;
            }
        }
        return grid;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Flip Square Submatrix Vertically");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}