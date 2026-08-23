// Vandalism
namespace CompetitiveProgramming.Kattis.Vandalism;
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
        string chars = "UAPC";

        foreach (char c in chars)
        {
            if (!s.Contains(c))
            {
                Console.Write(c);
            }
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vandalism");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}