// Collatz Conjecture
namespace CompetitiveProgramming.CodeForces.CollatzConjecture;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long x = long.Parse(input[0]);
            long y = long.Parse(input[1]);
            long k = long.Parse(input[2]);
            
            while (k > 0 && x != 1)
            {
                long d = (x / y + 1) * y - x;
                if (d == 0) d = 1;
                if (d > k) d = k;
                x += d;
                while (x % y == 0) x /= y;
                k -= d;
            }
            
            Console.WriteLine(x + k % (y - 1));
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Collatz Conjecture");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}