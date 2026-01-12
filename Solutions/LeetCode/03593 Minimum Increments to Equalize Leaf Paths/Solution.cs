// Minimum Increments to Equalize Leaf Paths
namespace CompetitiveProgramming.LeetCode.MinimumIncrementstoEqualizeLeafPaths;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8618

public class Solution
{
    private HashSet<int>[] adjs;
    private int res = 0;

    private void BuildAdj(int[][] edges)
    {
        int size = adjs.Length;
        for(int i = 0; i < size; i++)
        {
            adjs[i] = new HashSet<int>();
        }

        foreach(int[] edge in edges)
        {
            int from = edge[0], to = edge[1];
            adjs[from].Add(to);
            adjs[to].Add(from);
        }
    }

    private long DFS(int node, int par, int[] cost)
    {
        long maxChildSum = 0;
        List<long> childSums = new();
        foreach(int chd in adjs[node])
        {
            if(chd == par)
                continue;

            long tmpSum = DFS(chd, node, cost);
            childSums.Add(tmpSum);
            maxChildSum = Math.Max(maxChildSum, tmpSum);
        }

        foreach(long cur in childSums)
        {
            if(cur != maxChildSum)
                res++;
        }

        return cost[node] + maxChildSum;
    }

    public int MinIncrease(int n, int[][] edges, int[] cost)
    {
        adjs = new HashSet<int>[n];
        BuildAdj(edges);

        DFS(0, -1, cost);

        return res;
    }
}

#pragma warning restore CS86018
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Increments to Equalize Leaf Paths");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}