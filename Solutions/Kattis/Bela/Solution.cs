// Bela
namespace CompetitiveProgramming.Kattis.Bela;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        Dictionary<string, (int, int)> val = new Dictionary<string, (int, int)>
        {
            { "A", (11, 11) },
            { "K", (4, 4) },
            { "Q", (3, 3) },
            { "J", (20, 2) },
            { "T", (10, 10) },
            { "9", (14, 0) },
            { "8", (0, 0) },
            { "7", (0, 0) }
        };
        
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        string dom = input[1];
        
        n *= 4;
        int ans = 0;
        
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string c = line[0].ToString();
            if (line[1].ToString() == dom)
            {
                ans += val[c].Item1;
            }
            else
            {
                ans += val[c].Item2;
            }
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bela");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}