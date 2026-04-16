// Akureyri
namespace CompetitiveProgramming.Kattis.Akureyri;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> d = new Dictionary<string, int>();
        
        for (int i = 0; i < n; i++)
        {
            Console.ReadLine();
            string s = Console.ReadLine();
            if (d.ContainsKey(s))
                d[s]++;
            else
                d[s] = 1;
        }
        
        foreach (var kvp in d)
        {
            Console.WriteLine($"{kvp.Key} {kvp.Value}");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Akureyri");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}