// Preparation for International Women's Day
namespace CompetitiveProgramming.CodeForces.PreparationforInternationalWomensDay;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        long n = long.Parse(first[0]);
        long k = long.Parse(first[1]);

        long[] a = new long[k];
        string[] vals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++)
        {
            long d = long.Parse(vals[p]);
            a[d % k]++;
        }

        long total = a[0] - a[0] % 2;
        for (long p = 1; 2 * p <= k; p++)
        {
            total += 2 * ((a[p] < a[k - p]) ? a[p] : a[k - p]);
            if (2 * p == k) total -= a[p] + a[p] % 2;
        }

        Console.WriteLine(total);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Preparation for International Women's Day");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}