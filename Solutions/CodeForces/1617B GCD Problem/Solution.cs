// GCD Problem
namespace CompetitiveProgramming.CodeForces.GCDProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            if (n % 2 == 0) Console.WriteLine($"2 {n - 3} 1");
            else if (n % 4 == 1) Console.WriteLine($"{n/2 - 1} {n/2 + 1} 1");
            else if (n % 4 == 3) Console.WriteLine($"{n/2 - 2} {n/2 + 2} 1");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("GCD Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}