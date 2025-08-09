// Maximum Number of Points From Grid Queries
namespace CompetitiveProgramming.LeetCode.MaximumNumberofPointsFromGridQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

/*
using V = (int X, int Y); 

public sealed class Solution 
{
    private readonly static V[] D = new V[] 
    {
        (0, 1),
        (0, -1),
        (1, 0),
        (-1, 0)
    };

    private readonly static PriorityQueue<V, int> PQ = new PriorityQueue<V, int>();

    public int[] MaxPoints(int[][] grid, int[] queries) 
    {
        PQ.Clear();

        var n = grid.Length;
        var m = grid[0].Length;
        var k = queries.Length;
        var v = new bool[n, m];
        var r = 0;
        var ans = new int[k];

        PQ.Enqueue((0, 0), grid[0][0]);
        v[0, 0] = true;

        foreach (var (q, i) in queries.Select((x, i) => (x, i)).OrderBy(p => p.x)) 
        {
            while (PQ.Count > 0 && PQ.TryPeek(out var p, out var val) && val < q) 
            {
                r++;

                PQ.Dequeue();

                foreach(var d in D)
                {
                    V t = (p.X + d.X, p.Y + d.Y);

                    if (t.X >= 0 && t.X < n && t.Y >= 0 && t.Y < m && !v[t.X, t.Y]) 
                    {
                        PQ.Enqueue(t, grid[t.X][t.Y]);
                        v[t.X, t.Y] = true;
                    }
                }
            }

            ans[i] = r;
        }

        return ans;
    }
}
*/

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Points From Grid Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}