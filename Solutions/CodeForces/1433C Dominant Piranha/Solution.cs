// Dominant Piranha
namespace CompetitiveProgramming.CodeForces.DominantPiranha;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long mx = 0, mn = 2000000007;
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            for (long p = 0; p < n; p++)
            {
                mn = mn < a[p] ? mn : a[p];
                mx = mx > a[p] ? mx : a[p];
            }
            long where = -1;
            if (mn == mx) Console.WriteLine("-1");
            else
            {
                if (a[0] == mx && a[1] < mx) where = 1;
                else if (a[n - 1] == mx && a[n - 2] < mx) where = n;
                else
                {
                    for (long p = 1; p < n - 1; p++)
                    {
                        if (a[p] == mx && (a[p - 1] < mx || a[p + 1] < mx))
                        {
                            where = p + 1;
                            break;
                        }
                    }
                }
                Console.WriteLine(where);
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Dominant Piranha");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}