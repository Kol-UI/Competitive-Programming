// Spritt
namespace CompetitiveProgramming.Kattis.Spritt;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int x = int.Parse(firstLine[1]);
        
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            x -= a;
        }
        
        Console.WriteLine(x >= 0 ? "Jebb" : "Neibb");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Spritt");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}