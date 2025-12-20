// Perfect Squares
namespace CompetitiveProgramming.CodeForces.PerfectSquares;
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
        int n = int.Parse(Console.ReadLine());
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long result = -100000000;
        
        foreach (long x in numbers)
        {
            if (x >= 0)
            {
                long root = (long)Math.Sqrt(x);
                if (root * root < x && x > result) result = x;
            }
            else if (x > result) result = x;
        }
        
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Perfect Squares");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}