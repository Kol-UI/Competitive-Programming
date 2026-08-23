// Herb Mixing
namespace CompetitiveProgramming.Kattis.HerbMixing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int g = int.Parse(input[0]);
        int r = int.Parse(input[1]);

        int m = Math.Min(g, r);
        int ans = 0;

        ans += 10 * m;
        g -= m;
        r -= m;

        while (g >= 3)
        {
            ans += 10;
            g -= 3;
        }

        while (g >= 2)
        {
            ans += 3;
            g -= 2;
        }

        ans += g;

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Herb Mixing");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}