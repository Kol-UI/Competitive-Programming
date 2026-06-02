// Stairs
namespace CompetitiveProgramming.CodeForces.Stairs;
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
            long y = 1;
            long res = 0;
            
            while (2 * x >= y * (y + 1))
            {
                x -= y * (y + 1) / 2;
                y = 2 * y + 1;
                res++;
            }
            
            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Stairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}