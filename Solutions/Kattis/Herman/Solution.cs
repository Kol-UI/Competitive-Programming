// Herman
namespace CompetitiveProgramming.Kattis.Herman;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        double i = double.Parse(Console.ReadLine());
        
        Console.WriteLine($"{Math.PI * i * i:F8}");
        Console.WriteLine($"{i * i * 2:F8}");
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Herman");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}