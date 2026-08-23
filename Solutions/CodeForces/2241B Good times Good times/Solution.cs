// Good times Good times
namespace CompetitiveProgramming.CodeForces.GoodtimesGoodtimes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long x = long.Parse(Console.ReadLine());
            long w = x;
            long z = 1;

            while (w > 0)
            {
                z *= 10;
                w /= 10;
            }

            Console.WriteLine(z + 1);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Good times Good times");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}