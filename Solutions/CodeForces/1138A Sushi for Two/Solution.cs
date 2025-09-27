// Sushi for Two
namespace CompetitiveProgramming.CodeForces.SushiforTwo;
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
        long n = long.Parse(Console.ReadLine());
        long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long x = a[0] == 1 ? 1 : 0;
        long y = a[0] == 2 ? 1 : 0;
        long cur = 0, mx = 0;
        for (long p = 1; p < n; p++)
        {
            if (a[p] == 1 && a[p - 1] == 1) x++;
            else if (a[p] == 2 && a[p - 1] == 2) y++;
            else if (a[p] == 1 && a[p - 1] == 2) x = 1;
            else if (a[p] == 2 && a[p - 1] == 1) y = 1;
            cur = Math.Min(x, y);
            mx = Math.Max(mx, cur);
        }
        Console.WriteLine(2 * mx);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sushi for Two");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}