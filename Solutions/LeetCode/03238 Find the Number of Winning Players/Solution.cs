// Find the Number of Winning Players
namespace CompetitiveProgramming.LeetCode.FindtheNumberofWinningPlayers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int WinningPlayerCount(int n, int[][] pick) => pick
        .GroupBy(m => new { Player = m[0], Color = m[1] })
        .Where(m => m.Key.Player < m.Count())
        .Select(m => m.Key.Player)
        .Distinct()
        .Count();
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Number of Winning Players");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}