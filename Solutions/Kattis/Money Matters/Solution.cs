// Money Matters
namespace CompetitiveProgramming.Kattis.MoneyMatters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class UnionFind
{
    public int n;
    public int[] p;
    public long[] val;

    public UnionFind(int n)
    {
        this.n = n;
        p = new int[n];
        val = new long[n];
        for (int i = 0; i < n; i++)
        {
            p[i] = i;
            val[i] = 0;
        }
    }

    public void SetVal(int i, long v)
    {
        val[i] = v;
    }

    public int Find(int i)
    {
        if (i == p[i]) return i;
        p[i] = Find(p[i]);
        return p[i];
    }

    public void Join(int i, int j)
    {
        int ip = Find(i);
        int jp = Find(j);
        if (ip == jp) return;

        val[jp] += val[ip];
        p[ip] = jp;
    }
}

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        UnionFind uf = new UnionFind(n);

        for (int i = 0; i < n; i++)
        {
            long v = long.Parse(Console.ReadLine());
            uf.SetVal(i, v);
        }

        for (int i = 0; i < m; i++)
        {
            string[] edge = Console.ReadLine().Split();
            int u = int.Parse(edge[0]);
            int v = int.Parse(edge[1]);
            uf.Join(u, v);
        }

        for (int i = 0; i < n; i++)
        {
            int p = uf.Find(i);
            if (uf.val[p] != 0)
            {
                Console.WriteLine("IMPOSSIBLE");
                return;
            }
        }
        Console.WriteLine("POSSIBLE");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Money Matters");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}