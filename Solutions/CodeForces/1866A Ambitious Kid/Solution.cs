// Ambitious Kid
namespace CompetitiveProgramming.CodeForces.AmbitiousKid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        long minAbsolute = 100007;
        foreach (long number in numbers)
        {
            long absolute = Math.Abs(number);
            minAbsolute = Math.Min(minAbsolute, absolute);
        }
        
        Console.WriteLine(minAbsolute);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ambitious Kid");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}