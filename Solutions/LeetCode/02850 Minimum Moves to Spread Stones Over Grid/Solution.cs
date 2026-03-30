// Minimum Moves to Spread Stones Over Grid
namespace CompetitiveProgramming.LeetCode.MinimumMovestoSpreadStonesOverGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    List<(int x, int y)> emptyPos = new();
    List<(int x, int y)> notEmptyPos = new();

    public int MinimumMoves(int[][] grid)
    {
        int size = grid.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (grid[i][j] == 0)
                {
                    emptyPos.Add((i, j));
                }
                else if (grid[i][j] > 1)
                {
                    notEmptyPos.Add((i, j));
                }
            }
        }

        return Func(grid, 0);
    }

    public int Func(int[][] grid, int filledEmpty)
    {
        if (filledEmpty == emptyPos.Count) return 0;

        int minDistance = int.MaxValue;

        foreach (var notEmpty in notEmptyPos)
        {
            if (grid[notEmpty.x][notEmpty.y] == 1) continue;

            foreach (var empty in emptyPos)
            {
                if (grid[empty.x][empty.y] == 1) continue;

                grid[empty.x][empty.y] += 1;
                grid[notEmpty.x][notEmpty.y] -= 1;
                int d = Math.Abs(notEmpty.x - empty.x) + Math.Abs(notEmpty.y - empty.y);

                minDistance = Math.Min(minDistance, d + Func(grid, filledEmpty + 1));

                grid[notEmpty.x][notEmpty.y] += 1;
                grid[empty.x][empty.y] -= 1;
            }
        }

        return minDistance;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Moves to Spread Stones Over Grid");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}