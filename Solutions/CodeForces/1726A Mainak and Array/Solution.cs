// Mainak and Array
namespace CompetitiveProgramming.CodeForces.MainakandArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToList();
            
            long ans = -2000;
            
            for (int p = 1; p < n; p++)
            {
                long tst = a[p] - a[0];
                ans = Math.Max(ans, tst);
            }
            
            for (int p = 0; p < n - 1; p++)
            {
                long tst = a[(int)n - 1] - a[p];
                ans = Math.Max(ans, tst);
            }
            
            for (int p = 0; p < n; p++)
            {
                long tst = a[(int)(p - 1 + n) % (int)n] - a[p];
                ans = Math.Max(ans, tst);
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Mainak and Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}