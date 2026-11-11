// Forever Winter
namespace CompetitiveProgramming.CodeForces.ForeverWinter;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            int n = int.Parse(first[0]);
            int m = int.Parse(first[1]);

            List<int>[] g = new List<int>[n + 1];
            for (int p = 0; p <= n; p++) g[p] = new List<int>();

            for (int p = 0; p < m; p++)
            {
                string[] ab = Console.ReadLine().Split();
                int a = int.Parse(ab[0]);
                int b = int.Parse(ab[1]);
                g[a].Add(b);
                g[b].Add(a);
            }

            long x = 0, y = 0;
            for (int p = 1; y == 0 && p <= n; p++)
            {
                if (g[p].Count == 1)
                {
                    int middle = g[p][0];
                    y = g[middle].Count - 1;
                    for (int q = 0; x == 0 && q < g[middle].Count; q++)
                    {
                        int center = g[middle][q];
                        if (g[center].Count == 1) continue;
                        x = g[center].Count;
                    }
                }
            }

            Console.WriteLine(x + " " + y);
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
        StyleHelper.Title("Forever Winter");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}