// Hermits
namespace CompetitiveProgramming.Kattis.Hermits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        const int mxN = 1005;

        long n = long.Parse(Console.ReadLine());
        long[] a = new long[n];
        string[] aVals = Console.ReadLine().Split();
        for (int i = 0; i < n; i++) a[i] = long.Parse(aVals[i]);

        long m = long.Parse(Console.ReadLine());
        List<int>[] adj = new List<int>[mxN];
        for (int i = 0; i < mxN; i++) adj[i] = new List<int>();

        for (int i = 0; i < m; i++)
        {
            string[] uv = Console.ReadLine().Split();
            int u = int.Parse(uv[0]) - 1;
            int v = int.Parse(uv[1]) - 1;
            adj[u].Add(v);
            adj[v].Add(u);
        }

        int ans = 0;
        long anss = (long)1e15;

        for (int u = 0; u < n; u++)
        {
            long cur = a[u];
            foreach (int v in adj[u])
                cur += a[v];

            if (cur < anss)
            {
                anss = cur;
                ans = u;
            }
        }
        Console.WriteLine(ans + 1);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hermits");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}