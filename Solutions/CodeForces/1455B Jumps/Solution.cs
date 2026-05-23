// Jumps
namespace CompetitiveProgramming.CodeForces.Jumps;
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
            long step = 1;
            long total = 0;
            
            while (total < x)
            {
                total += step;
                step++;
            }
            
            if (total != x + 1)
            {
                step--;
            }
            
            Console.WriteLine(step);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Jumps");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}