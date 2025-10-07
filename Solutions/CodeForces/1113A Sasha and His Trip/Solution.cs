// Sasha and His Trip
namespace CompetitiveProgramming.CodeForces.SashaandHisTrip;
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
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long v = long.Parse(input[1]);
        
        long ans;
        if (v >= n)
        {
            ans = n - 1;
        }
        else
        {
            ans = (v - 1) + (n - v) * (n - v + 1) / 2;
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sasha and His Trip");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}