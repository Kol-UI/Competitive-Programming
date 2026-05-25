// Awkward Party
namespace CompetitiveProgramming.Kattis.AwkwardParty;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        
        Dictionary<long, List<long>> m = new Dictionary<long, List<long>>();
        
        for (long i = 0; i < n; i++)
        {
            long t = long.Parse(input[i]);
            if (!m.ContainsKey(t))
                m[t] = new List<long>();
            m[t].Add(i);
        }
        
        long ans = n;
        foreach (var kvp in m)
        {
            for (int j = 1; j < kvp.Value.Count; j++)
            {
                long diff = kvp.Value[j] - kvp.Value[j - 1];
                if (diff < ans) ans = diff;
            }
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Awkward Party");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}