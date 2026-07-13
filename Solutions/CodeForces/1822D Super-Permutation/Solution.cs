// Super-Permutation
namespace CompetitiveProgramming.CodeForces.SuperPermutation;
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
            long n = long.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("1");
                continue;
            }
            if (n % 2 == 1)
            {
                Console.WriteLine("-1");
                continue;
            }
            for (long p = 0; p < n; p++)
            {
                long val = (p % 2 == 1) ? p : (n - p);
                Console.Write($"{val} ");
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Super-Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}