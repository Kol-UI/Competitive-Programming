// Gangur
namespace CompetitiveProgramming.Kattis.Gangur;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine() ?? "";

        long ans = 0;
        long nr = 0;

        foreach (char c in input)
        {
            if (c == '>')
            {
                nr++;
            }
            else if (c == '<')
            {
                ans += nr;
            }
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Gangur");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}