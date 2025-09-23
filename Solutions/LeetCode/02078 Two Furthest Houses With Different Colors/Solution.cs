// Two Furthest Houses With Different Colors
namespace CompetitiveProgramming.LeetCode.TwoFurthestHousesWithDifferentColors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxDistance(Span<int> colors)
    {
        var i = colors.IndexOfAnyExcept(colors[0]);
        var j = colors.LastIndexOfAnyExcept(colors[0]);
        return Math.Max(colors.Length - i - 1, j);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Two Furthest Houses With Different Colors");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}