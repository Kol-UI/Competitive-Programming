// Treehouses
namespace CompetitiveProgramming.Kattis.Treehouses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    struct Edge
    {
        public int N1;
        public int N2;
        public double D;
    }

    static int Find(int[] d, int a)
    {
        if (d[a] == -1) return a;
        return d[a] = Find(d, d[a]);
    }

    static void Join(int[] d, int a, int b)
    {
        a = Find(d, a);
        b = Find(d, b);
        if (a == b) return;
        d[a] = b;
    }

    static double Dist((double First, double Second) p1, (double First, double Second) p2)
    {
        double d1 = Math.Pow(p1.First - p2.First, 2);
        double d2 = Math.Pow(p1.Second - p2.Second, 2);
        return Math.Sqrt(d1 + d2);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        string[] nmk = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(nmk[0]);
        int m = int.Parse(nmk[1]);
        int k = int.Parse(nmk[2]);

        (double First, double Second)[] v = new (double, double)[n];
        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            v[i] = (double.Parse(parts[0]), double.Parse(parts[1]));
        }

        int[] d = new int[n];
        Array.Fill(d, -1);

        for (int i = 1; i < m; i++)
        {
            d[i] = 0;
        }

        for (int i = 0; i < k; i++)
        {
            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int n1 = int.Parse(parts[0]);
            int n2 = int.Parse(parts[1]);
            Join(d, n1 - 1, n2 - 1);
        }

        List<Edge> edges = new List<Edge>();
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                Edge e;
                e.N1 = i;
                e.N2 = j;
                e.D = Dist(v[i], v[j]);
                edges.Add(e);
            }
        }

        edges.Sort((e1, e2) => e1.D.CompareTo(e2.D));

        double total = 0;
        foreach (var i in edges)
        {
            if (Find(d, i.N1) != Find(d, i.N2))
            {
                Join(d, i.N1, i.N2);
                total += i.D;
            }
        }

        Console.WriteLine(total.ToString("F6"));
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Treehouses");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}