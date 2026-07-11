// Incognito
namespace CompetitiveProgramming.Kattis.Incognito;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> m = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string s1 = input[0];
            string s2 = input[1];

            if (!m.ContainsKey(s2))
                m[s2] = 0;
            m[s2]++;
        }

        int ans = 1;
        foreach (var kvp in m)
        {
            ans *= kvp.Value + 1;
        }

        Console.WriteLine(ans - 1);
    }

    static void Main()
    {
        int cases = int.Parse(Console.ReadLine());
        while (cases-- > 0)
        {
            Solve();
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
        StyleHelper.Title("Incognito");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}