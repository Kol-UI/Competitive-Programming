// Drazil and Date
namespace CompetitiveProgramming.CodeForces.DrazilandDate;
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
        long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long a = Math.Abs(input[0]);
        long b = Math.Abs(input[1]);
        long s = input[2];
        
        long distance = a + b;
        bool reachable = s >= distance && (s - distance) % 2 == 0;
        Console.WriteLine(reachable ? "Yes" : "No");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Drazil and Date");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}