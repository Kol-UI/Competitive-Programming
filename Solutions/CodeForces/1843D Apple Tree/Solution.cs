// Apple Tree
namespace CompetitiveProgramming.CodeForces.AppleTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    static void Dfs(int u, int x, int[] Lf, List<int>[] adj)
    {
        if (u != 0 && adj[u].Count == 1)
            Lf[u] = 1;
        foreach (var v in adj[u])
        {
            if (v != x)
            {
                Dfs(v, u, Lf, adj);
                Lf[u] += Lf[v];
            }
        }
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            List<int>[] adj = new List<int>[n];
            for (int i = 0; i < n; i++)
                adj[i] = new List<int>();

            for (int i = 0; i < n - 1; i++)
            {
                int[] uv = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int u = uv[0] - 1;
                int v = uv[1] - 1;
                adj[u].Add(v);
                adj[v].Add(u);
            }

            int[] Lf = new int[n];
            Dfs(0, -1, Lf, adj);

            int q = int.Parse(Console.ReadLine()!);
            while (q-- > 0)
            {
                int[] query = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int u = query[0] - 1;
                int v = query[1] - 1;
                Console.WriteLine((long)Lf[u] * Lf[v]);
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Apple Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}