// Nastia and a Good Array
namespace CompetitiveProgramming.CodeForces.NastiaandaGoodArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] a = new long[n];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) a[p] = long.Parse(vals[p]);

            Console.WriteLine(n / 2);
            for (long p = 1; p < n; p += 2)
            {
                long mn = a[p - 1] < a[p] ? a[p - 1] : a[p];
                Console.WriteLine((p) + " " + (p + 1) + " " + mn + " 1000000007");
            }
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
        StyleHelper.Title("Nastia and a Good Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}