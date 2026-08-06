// Make It Permutation
namespace CompetitiveProgramming.CodeForces.MakeItPermutation;
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
            Console.WriteLine(2 * n - 1);
            
            for (long p = 1; p < n; p++)
            {
                Console.WriteLine($"{p} 1 {p}");
                Console.WriteLine($"{p} {p + 1} {n}");
            }
            Console.WriteLine($"{n} 1 {n}");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make It Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}