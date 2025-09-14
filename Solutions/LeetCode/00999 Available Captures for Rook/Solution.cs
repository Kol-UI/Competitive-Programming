// Available Captures for Rook
namespace CompetitiveProgramming.LeetCode.AvailableCapturesforRook;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumRookCaptures(char[][] board)
    {
        var result = 0;
        var n = board.Length;
        var pawns = new int[4];

        for (var i = 0; i < n; i++, Array.Clear(pawns))
        for (var j = 0; j < n; j++)
        {
            var k = n - j - 1;
            CheckCell(0, i, j);
            CheckCell(1, i, k);
            CheckCell(2, j, i);
            CheckCell(3, k, i);
        }

        return result;

        void CheckCell(int dir, int row, int col)
        {
            var _ = board[row][col] switch
            {
                'R' => result += pawns[dir],
                'B' => pawns[dir] = 0,
                'p' => pawns[dir] = 1,
                '.' => pawns[dir],
                _ => throw new NotImplementedException(),
            };
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Available Captures for Rook");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}