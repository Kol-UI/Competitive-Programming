// Getting Wood
namespace CompetitiveProgramming.Kattis.GettingWood;
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

        if (!s.Contains("tree"))
        {
            Console.WriteLine("no trees here");
        }
        else
        {
            Console.WriteLine(s.IndexOf("tree"));
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Getting Wood");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}