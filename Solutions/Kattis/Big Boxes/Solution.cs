// Big Boxes
namespace CompetitiveProgramming.Kattis.BigBoxes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600
#pragma warning disable CS8618

using System;

class Solution
{
    static long n, k;
    static long[] a;

    static bool Check(long wg)
    {
        long ng = 1;
        long sm = 0;
        for (int i = 0; i < n; ++i)
        {
            if (a[i] > wg) return false;
            if (sm + a[i] > wg)
            {
                ++ng;
                sm = a[i];
            }
            else sm += a[i];
        }
        return ng <= k;
    }

    static void Main()
    {
        string line1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line1)) return;

        string[] nk = line1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        n = long.Parse(nk[0]);
        k = long.Parse(nk[1]);

        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        a = new long[n];
        for (int i = 0; i < n; ++i)
        {
            a[i] = long.Parse(parts[i]);
        }

        long lo = 0;
        long hi = (long)1e10;
        while (lo < hi)
        {
            long mid = (lo + hi) / 2;
            if (Check(mid))
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        Console.WriteLine(lo);
    }
}

#pragma warning restore CS8618
#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Big Boxes");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}