// Mahmoud and Ehab and the bipartiteness
namespace CompetitiveProgramming.CodeForces.MahmoudandEhabandthebipartiteness;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Dfs(long node, List<long>[] g, bool[] visited, bool[] gv, bool grp)
    {
        if (visited[node]) return;
        visited[node] = true;
        gv[node] = grp;
        foreach (long u in g[node])
        {
            if (visited[u]) continue;
            Dfs(u, g, visited, gv, !grp);
        }
    }

    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        List<long>[] g = new List<long>[n];
        for (long p = 0; p < n; p++) g[p] = new List<long>();

        for (long p = 1; p < n; p++)
        {
            string[] xy = Console.ReadLine().Split();
            long x = long.Parse(xy[0]) - 1;
            long y = long.Parse(xy[1]) - 1;
            g[x].Add(y);
            g[y].Add(x);
        }

        bool[] visited = new bool[n];
        bool[] gv = new bool[n];
        Dfs(0, g, visited, gv, false);

        long a = 0;
        for (long p = 0; p < n; p++) if (gv[p]) a++;
        long b = n - a;

        long ans = a * b - (n - 1);
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mahmoud and Ehab and the bipartiteness");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}