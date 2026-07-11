// Get Shorty
namespace CompetitiveProgramming.Kattis.GetShorty;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int m = int.Parse(firstLine[1]);
            if (n == 0) break;

            List<(double w, int v)>[] adj = new List<(double, int)>[n];
            for (int i = 0; i < n; i++)
                adj[i] = new List<(double, int)>();

            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();
                int u = int.Parse(input[0]);
                int v = int.Parse(input[1]);
                double f = double.Parse(input[2]);

                if (f != 0)
                {
                    double w = -Math.Log(f);
                    adj[u].Add((w, v));
                    adj[v].Add((w, u));
                }
            }

            double[] dist = new double[n];
            for (int i = 0; i < n; i++)
                dist[i] = double.PositiveInfinity;

            dist[0] = 0.0;

            var pq = new SortedSet<(double d, int u)>();
            pq.Add((0.0, 0));

            while (pq.Count > 0)
            {
                var (d, u) = pq.Min;
                pq.Remove(pq.Min);

                if (d > dist[u]) continue;

                foreach (var (w, v) in adj[u])
                {
                    if (dist[u] + w < dist[v])
                    {
                        dist[v] = dist[u] + w;
                        pq.Add((dist[v], v));
                    }
                }
            }

            double result = Math.Exp(-dist[n - 1]);
            Console.WriteLine($"{result:F4}");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Get Shorty");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}