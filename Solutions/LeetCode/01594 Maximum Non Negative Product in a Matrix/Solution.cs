// Maximum Non Negative Product in a Matrix
namespace CompetitiveProgramming.LeetCode.MaximumNonNegativeProductinaMatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
/*
#pragma warning disable CS8618
public class Solution
{
    int max = 0;
    (long, long)[][] maxProds;
    int[][] dirs = new int[2][] { new int[] { 0, 1 }, new int[] { 1, 0 } };
    int mod = (int)Math.Pow(10, 9) + 7;
    HashSet<int> read = new();

    public int MaxProductPath(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        maxProds = new (long, long)[m][];

        for (int i = 0; i < m; ++i)
        {
            maxProds[i] = new (long, long)[n];
            for (int j = 0; j < n; ++j)
            {
                maxProds[i][j] = (long.MinValue, long.MaxValue);
            }
        }

        maxProds[0][0] = (grid[0][0], grid[0][0]);
        var q = new Queue<(int, int)>();
        q.Enqueue((0, 0));
        read.Add(0);

        while (q.Count > 0)
        {
            var (r, c) = q.Dequeue();
            var (currMax, currMin) = maxProds[r][c];

            foreach (var dir in dirs)
            {
                int nr = r + dir[0];
                int nc = c + dir[1];

                if (nr >= 0 && nr < m && nc >= 0 && nc < n)
                {
                    var val = grid[nr][nc];
                    long max, min;
                    if (val > 0)
                    {
                        max = currMax * val;
                        min = currMin * val;
                    }
                    else
                    {
                        max = currMin * val;
                        min = currMax * val;
                    }

                    max = Math.Max(maxProds[nr][nc].Item1, max);
                    min = Math.Min(maxProds[nr][nc].Item2, min);

                    maxProds[nr][nc] = (max, min);

                    if (!read.Contains(n * nr + nc))
                    {
                        q.Enqueue((nr, nc));
                        read.Add(n * nr + nc);
                    }
                }
            }
        }

        var finMax = maxProds[m - 1][n - 1].Item1;
        return (int)(finMax < 0 ? -1 : finMax % mod);
    }
}
#pragma warning restore CS8618
*/
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Non Negative Product in a Matrix");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}