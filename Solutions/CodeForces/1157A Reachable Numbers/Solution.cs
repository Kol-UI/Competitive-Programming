// Reachable Numbers
namespace CompetitiveProgramming.CodeForces.ReachableNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long s = n >= 10 ? 1 : 0;
        while (n >= 10)
        {
            s += 9 - n % 10;
            n /= 10;
        }
        s += 9;
        Console.WriteLine(s);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reachable Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
