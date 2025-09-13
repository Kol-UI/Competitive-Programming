// Ideal Point
namespace CompetitiveProgramming.CodeForces.IdealPoint;
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
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);
            bool bl = false, br = false;
            for (long p = 0; p < n; p++)
            {
                string[] segment = Console.ReadLine().Split();
                long left = long.Parse(segment[0]);
                long right = long.Parse(segment[1]);
                if (k == left) bl = true;
                if (k == right) br = true;
            }
            Console.WriteLine(bl && br ? "YES" : "NO");
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
        StyleHelper.Title("Ideal Point");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}