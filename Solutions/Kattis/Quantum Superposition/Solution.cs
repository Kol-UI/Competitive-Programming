// Quantum Superposition
namespace CompetitiveProgramming.Kattis.QuantumSuperposition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    const int mxN = 1005;
    static int n1, n2, m1, m2;
    static List<int>[][] adj = new List<int>[2][];
    static bool[][] vis = new bool[2][];
    static bool[][][] can = new bool[2][][];

    static void Dfs(int u, int n, int t)
    {
        if (vis[t][u]) return;
        vis[t][u] = true;

        if (u == n - 1)
        {
            can[t][u][0] = true;
        }

        foreach (int v in adj[t][u])
        {
            Dfs(v, n, t);
            for (int k = 0; k <= 2000; k++)
            {
                if (can[t][v][k])
                {
                    can[t][u][k + 1] = true;
                }
            }
        }
    }

    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        n1 = int.Parse(firstLine[0]);
        n2 = int.Parse(firstLine[1]);
        m1 = int.Parse(firstLine[2]);
        m2 = int.Parse(firstLine[3]);

        adj[0] = new List<int>[mxN];
        adj[1] = new List<int>[mxN];
        for (int i = 0; i < mxN; i++)
        {
            adj[0][i] = new List<int>();
            adj[1][i] = new List<int>();
        }

        for (int i = 0; i < m1; i++)
        {
            string[] edge = Console.ReadLine().Split();
            int u = int.Parse(edge[0]) - 1;
            int v = int.Parse(edge[1]) - 1;
            adj[0][u].Add(v);
        }

        for (int i = 0; i < m2; i++)
        {
            string[] edge = Console.ReadLine().Split();
            int u = int.Parse(edge[0]) - 1;
            int v = int.Parse(edge[1]) - 1;
            adj[1][u].Add(v);
        }

        vis[0] = new bool[mxN];
        vis[1] = new bool[mxN];
        can[0] = new bool[mxN][];
        can[1] = new bool[mxN][];

        for (int i = 0; i < mxN; i++)
        {
            can[0][i] = new bool[2005];
            can[1][i] = new bool[2005];
        }

        Dfs(0, n1, 0);
        Dfs(0, n2, 1);

        int q = int.Parse(Console.ReadLine());

        while (q-- > 0)
        {
            int d = int.Parse(Console.ReadLine());
            bool fail = true;

            for (int i = 0; i <= d; i++)
            {
                if (can[0][0][i] && can[1][0][d - i])
                {
                    fail = false;
                    break;
                }
            }

            Console.WriteLine(fail ? "No" : "Yes");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Quantum Superposition");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}