// Count Covered Buildings
namespace CompetitiveProgramming.LeetCode.CountCoveredBuildings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountCoveredBuildings(int n, int[][] buildings)
    {
        var xy = new Dictionary<int, List<int>>();
        var yx = new Dictionary<int, List<int>>();

        foreach (var b in buildings)
        {
            int x = b[0], y = b[1];
            if (!xy.ContainsKey(x)) xy[x] = new List<int> { int.MaxValue, int.MinValue };
            xy[x][0] = Math.Min(xy[x][0], y);
            xy[x][1] = Math.Max(xy[x][1], y);

            if (!yx.ContainsKey(y)) yx[y] = new List<int> { int.MaxValue, int.MinValue };
            yx[y][0] = Math.Min(yx[y][0], x);
            yx[y][1] = Math.Max(yx[y][1], x);
        }

        int count = 0;

        foreach (var b in buildings)
        {
            int x = b[0], y = b[1];
            if (yx[y][0] < x && x < yx[y][1] && xy[x][0] < y && y < xy[x][1])
            {
                count++;
            }
        }

        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Covered Buildings");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}