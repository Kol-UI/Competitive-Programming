// Equalize Prices
namespace CompetitiveProgramming.CodeForces.EqualizePrices;
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
        long q = long.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long mn = 1000000000, mx = 0;
            foreach (long x in arr)
            {
                mn = Math.Min(mn, x);
                mx = Math.Max(mx, x);
            }
            if (mx - mn <= 2 * k) Console.WriteLine(mn + k);
            else Console.WriteLine("-1");
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
        StyleHelper.Title("Equalize Prices");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}