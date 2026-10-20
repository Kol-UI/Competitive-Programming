// Rumor
namespace CompetitiveProgramming.CodeForces.Rumor;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Solution
{
    static void Dfs(long node, ref long minCost, bool[] vis, long[] costVec, List<long>[] g)
    {
        if (vis[node]) return;
        vis[node] = true;
        if (costVec[node] < minCost) minCost = costVec[node];
        foreach (long u in g[node])
        {
            if (vis[u]) continue;
            Dfs(u, ref minCost, vis, costVec, g);
        }
    }

    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        long n = long.Parse(first[0]);
        long m = long.Parse(first[1]);

        long[] costVec = new long[n];
        string[] costVals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++) costVec[p] = long.Parse(costVals[p]);

        List<long>[] g = new List<long>[n];
        for (long p = 0; p < n; p++) g[p] = new List<long>();

        for (long p = 0; p < m; p++)
        {
            string[] xy = Console.ReadLine().Split();
            long x = long.Parse(xy[0]) - 1;
            long y = long.Parse(xy[1]) - 1;
            g[x].Add(y);
            g[y].Add(x);
        }

        long totalCost = 0;
        bool[] visited = new bool[n];

        for (long p = 0; p < n; p++)
        {
            if (visited[p]) continue;
            long compCost = costVec[p];
            Dfs(p, ref compCost, visited, costVec, g);
            totalCost += compCost;
        }

        Console.WriteLine(totalCost);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rumor");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}