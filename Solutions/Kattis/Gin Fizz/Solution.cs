// Gin Fizz
namespace CompetitiveProgramming.Kattis.GinFizz;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{n * 45} ml gin");
        Console.WriteLine($"{n * 30} ml fresh lemon juice");
        Console.WriteLine($"{n * 10} ml simple syrup");
        Console.WriteLine($"{n} slice{(n > 1 ? "s" : "")} of lemon");
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Gin Fizz");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}