// Trip Planning
namespace CompetitiveProgramming.Kattis.TripPlanning;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);

        int[] edge = new int[n];
        for (int i = 0; i < n; i++) edge[i] = -1;

        for (int i = 0; i < m; i++)
        {
            string[] uv = Console.ReadLine().Split();
            int u = int.Parse(uv[0]) - 1;
            int v = int.Parse(uv[1]) - 1;

            if (u == (v + 1) % n)
            {
                int tmp = u;
                u = v;
                v = tmp;
            }

            if (v != (u + 1) % n) continue;

            edge[u] = i;
        }

        if (n == 2)
        {
            int mx = Math.Max(edge[0], edge[1]);
            edge[0] = mx;
            edge[1] = mx;
        }

        if (edge.Min() == -1)
        {
            Console.WriteLine("impossible");
            return;
        }

        foreach (int e in edge)
            Console.WriteLine(e + 1);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Trip Planning");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}