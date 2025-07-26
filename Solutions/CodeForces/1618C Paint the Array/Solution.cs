// Paint the Array
namespace CompetitiveProgramming.CodeForces.PainttheArray;
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
    static long Gcd(long a, long b) => b == 0 ? a : Gcd(b, a % b);

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long x = 0, y = 0;

            for (int p = 0; p < n; p++)
            {
                if (p % 2 == 0) x = Gcd(x, a[p]);
                else y = Gcd(y, a[p]);
            }

            bool gx = true, gy = true;
            for (int p = 0; p < n; p++)
            {
                if (p % 2 == 0 && a[p] % y == 0) gy = false;
                else if (p % 2 == 1 && a[p] % x == 0) gx = false;
            }

            if (gx) Console.WriteLine(x);
            else if (gy) Console.WriteLine(y);
            else Console.WriteLine(0);
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
        StyleHelper.Title("Paint the Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}