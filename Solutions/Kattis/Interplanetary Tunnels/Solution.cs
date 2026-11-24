// Interplanetary Tunnels
namespace CompetitiveProgramming.Kattis.InterplanetaryTunnels;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Solution
{
    const int mxN = 10006;

    static int[] dist = new int[mxN];
    static List<int>[] adj = new List<int>[mxN];

    static void TestCase()
    {
        string[] first = Console.ReadLine().Split();
        int m = int.Parse(first[1]);

        for (int i = 0; i < mxN; i++) adj[i] = new List<int>();

        string[] st = Console.ReadLine().Split();
        int s = int.Parse(st[0]);
        int t = int.Parse(st[1]);

        for (int i = 0; i < m; i++)
        {
            string[] uv = Console.ReadLine().Split();
            int u = int.Parse(uv[0]);
            int v = int.Parse(uv[1]);
            adj[u].Add(v);
            adj[v].Add(u);
        }

        for (int i = 0; i < mxN; i++) dist[i] = -1;

        Queue<int> q = new Queue<int>();
        dist[s] = 0;
        q.Enqueue(s);

        while (q.Count > 0)
        {
            int u = q.Dequeue();

            foreach (int v in adj[u])
            {
                if (dist[v] == -1)
                {
                    dist[v] = dist[u] + 1;
                    q.Enqueue(v);
                }
            }
        }

        Console.WriteLine((dist[t] + 1) / 2);
    }

    static void Main()
    {
        int t = 1;
        for (int tc = 1; tc <= t; tc++)
        {
            TestCase();
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Interplanetary Tunnels");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}