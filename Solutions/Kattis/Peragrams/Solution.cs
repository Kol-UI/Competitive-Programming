// Peragrams
namespace CompetitiveProgramming.Kattis.Peragrams;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int[] v = new int[26];

        foreach (char c in s)
        {
            v[c - 'a']++;
        }

        int odds = 0;

        foreach (int i in v)
        {
            if (i % 2 == 1)
            {
                odds++;
            }
        }

        int result = odds - 1;
        if (result < 0) result = 0;

        Console.WriteLine(result);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Peragrams");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}