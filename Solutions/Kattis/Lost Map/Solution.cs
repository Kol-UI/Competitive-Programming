// Lost Map
namespace CompetitiveProgramming.Kattis.LostMap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    struct Edge
    {
        public int n1;
        public int n2;
        public int dist;
    }

    static int Find(int[] d, int a)
    {
        if (d[a] < 0) return a;
        return d[a] = Find(d, d[a]);
    }

    static void Join(int[] d, int a, int b)
    {
        a = Find(d, a);
        b = Find(d, b);
        if (a == b) return;
        if (d[a] > d[b])
        {
            int temp = a;
            a = b;
            b = temp;
        }
        d[a] += d[b];
        d[b] = a;
    }

    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        List<Edge> e = new List<Edge>();

        for (int i = 0; i < v; i++)
        {
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < v; j++)
            {
                int num = int.Parse(input[j]);
                if (i > j)
                {
                    e.Add(new Edge { n1 = i, n2 = j, dist = num });
                }
            }
        }

        e.Sort((lhs, rhs) => lhs.dist.CompareTo(rhs.dist));

        int[] d = new int[v];
        for (int i = 0; i < v; i++) d[i] = -1;

        foreach (var edge in e)
        {
            int n1 = Find(d, edge.n1);
            int n2 = Find(d, edge.n2);
            if (n1 != n2)
            {
                Console.WriteLine($"{edge.n1 + 1} {edge.n2 + 1}");
                Join(d, n1, n2);
            }
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
        StyleHelper.Title("Lost Map");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}