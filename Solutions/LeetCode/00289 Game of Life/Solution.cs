// Game of Life
namespace CompetitiveProgramming.LeetCode.GameofLife;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public void GameOfLife(int[][] board)
    {
        int m = board.Length;
        int n = board[0].Length;
        
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                int count = 0;
                for (int p = Math.Max(i - 1, 0); p < Math.Min(i + 2, m); p++)
                    for (int q = Math.Max(j - 1, 0); q < Math.Min(j + 2, n); q++)
                        count += board[p][q] % 2;
                        
                if (count == 3 || count - board[i][j] == 3)
                    board[i][j] += 2;
            }
        
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                board[i][j] /= 2;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Game of Life");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}