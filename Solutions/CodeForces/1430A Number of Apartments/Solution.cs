// Number of Apartments
namespace CompetitiveProgramming.CodeForces.NumberofApartments;
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
            if (n == 1 || n == 2 || n == 4)
            {
                Console.WriteLine("-1");
                continue;
            }
            long a = 0, b = 0, c = n / 7;
            long remainder = n % 7;
            if (remainder == 1) { c--; a = 1; b = 1; }
            else if (remainder == 2) { c--; a = 3; }
            else if (remainder == 3) { a = 1; }
            else if (remainder == 4) { c--; a = 2; b = 1; }
            else if (remainder == 5) { b = 1; }
            else if (remainder == 6) { a = 2; }
            Console.WriteLine($"{a} {b} {c}");
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
        StyleHelper.Title("Number of Apartments");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}