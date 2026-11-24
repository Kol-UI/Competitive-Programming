// Sailing Friends
namespace CompetitiveProgramming.Kattis.SailingFriends;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class UnionFind
{
    public int num_sets;
    public int[] p, sz, rnk, bt;

    public UnionFind(int n)
    {
        num_sets = n;
        p = new int[n];
        for (int i = 0; i < n; i++) p[i] = i;
        rnk = new int[n];
        sz = new int[n];
        for (int i = 0; i < n; i++) sz[i] = 1;
        bt = new int[n];
    }

    public int Find(int i)
    {
        if (p[i] == i) return i;
        return p[i] = Find(p[i]);
    }

    public bool Check(int i, int j)
    {
        return Find(i) == Find(j);
    }

    public bool Join(int i, int j)
    {
        i = Find(i);
        j = Find(j);
        if (i == j) return false;

        if (rnk[i] < rnk[j])
        {
            sz[j] += sz[i];
            p[i] = j;
            if (bt[i] != 0) bt[j] = 1;
        }
        else
        {
            sz[i] += sz[j];
            p[j] = i;
            if (rnk[i] == rnk[j]) rnk[i]++;
            if (bt[j] != 0) bt[i] = 1;
        }

        num_sets--;
        return true;
    }
}

class Solution
{
    static void TestCase()
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int b = int.Parse(first[1]);
        int m = int.Parse(first[2]);

        UnionFind uf = new UnionFind(n);

        string[] bVals = Console.ReadLine().Split();
        for (int i = 0; i < b; i++)
        {
            int u = int.Parse(bVals[i]) - 1;
            uf.bt[u] = 1;
        }

        for (int i = 0; i < m; i++)
        {
            string[] uv = Console.ReadLine().Split();
            int u = int.Parse(uv[0]) - 1;
            int v = int.Parse(uv[1]) - 1;
            uf.Join(u, v);
        }

        HashSet<int> pars = new HashSet<int>();
        for (int i = 0; i < n; i++) pars.Add(uf.Find(i));

        int ans = 0;
        foreach (int i in pars)
            if (uf.bt[i] == 0) ans++;

        Console.WriteLine(ans);
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
        StyleHelper.Title("Sailing Friends");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}