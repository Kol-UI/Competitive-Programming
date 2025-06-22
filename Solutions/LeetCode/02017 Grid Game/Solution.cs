// Grid Game

namespace CompetitiveProgramming.LeetCode.GridGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long GridGame(int[][] grid)
    {
        int size = grid[0].Length;
        long result = long.MaxValue;

        long[] prefixTop = new long[size];
        long[] prefixBottom = new long[size];

        prefixTop[0] = grid[0][0];
        prefixBottom[0] = grid[1][0];

        for (int i = 1; i < size; i++)
        {
            prefixTop[i] = prefixTop[i - 1] + grid[0][i];
            prefixBottom[i] = prefixBottom[i - 1] + grid[1][i];
        }

        for (int col = 0; col < size; col++)
        {
            long pointsAbove = prefixTop[size - 1] - prefixTop[col];
            long pointsBelow = col > 0 ? prefixBottom[col - 1] : 0;

            long maxPointsSecondRobot = Math.Max(pointsAbove, pointsBelow);

            result = Math.Min(result, maxPointsSecondRobot);
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Grid Game");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}