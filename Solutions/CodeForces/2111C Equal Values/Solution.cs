// Equal Values
namespace CompetitiveProgramming.CodeForces.EqualValues;
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
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            long prev = long.Parse(input[0]);
            long left = 0;
            long cost = prev * (n - 1);

            for (long p = 1; p < n; p++)
            {
                long x = long.Parse(input[p]);
                long test = x * ((prev == x) ? (left + n - p - 1) : (n - 1));
                left = (prev == x) ? left : p;
                if (test < cost) cost = test;
                prev = x;
            }

            Console.WriteLine(cost);
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
        StyleHelper.Title("Equal Values");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}