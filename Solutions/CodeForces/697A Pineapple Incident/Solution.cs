// Pineapple Incident
namespace CompetitiveProgramming.CodeForces.PineappleIncident;
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
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long t = numbers[0];
        long s = numbers[1];
        long x = numbers[2];
        
        bool possible = x == t || ((x - t) / s > 0 && (x - t) % s <= 1);
        Console.WriteLine(possible ? "YES" : "NO");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pineapple Incident");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}