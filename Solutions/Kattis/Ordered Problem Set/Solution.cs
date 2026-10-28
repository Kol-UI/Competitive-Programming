// Ordered Problem Set
namespace CompetitiveProgramming.Kattis.OrderedProblemSet;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = int.Parse(Console.ReadLine());

        List<int> ans = new List<int>();

        for (int k = 2; k <= n; k++)
        {
            if (n % k != 0) continue;

            var sec = new SortedDictionary<int, List<int>>();
            for (int p = 1; p <= n; p++)
            {
                int s = (k * p + n - 1) / n;
                if (!sec.ContainsKey(s))
                    sec[s] = new List<int>();
                sec[s].Add(a[p - 1]);
            }

            bool works = true;

            foreach (var kv in sec)
            {
                foreach (var kv1 in sec)
                {
                    if (kv1.Key > kv.Key)
                    {
                        if (kv1.Value.Min() < kv.Value.Max())
                            works = false;
                    }
                }
            }

            if (works)
                ans.Add(k);
        }

        Console.WriteLine(ans.Count > 0 ? string.Join("\n", ans) : "-1");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ordered Problem Set");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}