// Find Maximum Area of a Triangle
namespace CompetitiveProgramming.LeetCode.FindMaximumAreaofaTriangle;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    public long MaxArea(int[][] coords)
    {
        long res = -1;
        Dictionary<int, int[]> xYsPairs = new(), yXsPairs = new();
        foreach (int[] cur in coords)
        {
            int x = cur[0], y = cur[1];

            if (!xYsPairs.ContainsKey(x))
                xYsPairs.Add(x, [y, y]);
            else
            {
                xYsPairs[x][0] = Math.Min(xYsPairs[x][0], y);
                xYsPairs[x][1] = Math.Max(xYsPairs[x][1], y);
            }

            if (!yXsPairs.ContainsKey(y))
                yXsPairs.Add(y, [x, x]);
            else
            {
                yXsPairs[y][0] = Math.Min(yXsPairs[y][0], x);
                yXsPairs[y][1] = Math.Max(yXsPairs[y][1], x);
            }
        }

        if (yXsPairs.Count == 1 && xYsPairs.Count == 1)
            return -1;

        List<int> xs = xYsPairs.Keys.ToList();
        xs.Sort();
        List<int> ys = yXsPairs.Keys.ToList();
        ys.Sort();
        int xLow = xs.First(), xHigh = xs.Last(), yLow = ys.First(), yHigh = ys.Last();

        foreach (int x in xs)
        {
            long distY = xYsPairs[x][1] - xYsPairs[x][0];
            if (distY > 0)
            {
                long tmp = distY * Math.Max(xHigh - x, x - xLow);
                res = Math.Max(res, tmp);
            }
        }

        foreach (int y in ys)
        {
            long distX = yXsPairs[y][1] - yXsPairs[y][0];
            if (distX > 0)
            {
                long tmp = distX * Math.Max(yHigh - y, y - yLow);
                res = Math.Max(res, tmp);
            }
        }

        return res == 0 ? -1 : res;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Maximum Area of a Triangle");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}