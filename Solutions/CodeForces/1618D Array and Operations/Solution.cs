// Array and Operations
namespace CompetitiveProgramming.CodeForces.ArrayandOperations;
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
            string[] first = Console.ReadLine().Split();
            long n = long.Parse(first[0]);
            long k = long.Parse(first[1]);

            long[] a = new long[n];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) a[p] = long.Parse(vals[p]);

            Array.Sort(a);

            long res = 0;
            for (long p = 0; p < n - 2 * k; p++) res += a[p];
            for (long p = 0; p < k; p++) res += a[n - k - 1 - p] / a[n - 1 - p];

            Console.WriteLine(res);
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
        StyleHelper.Title("Array and Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}