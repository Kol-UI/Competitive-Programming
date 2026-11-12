// Massive Card Game
namespace CompetitiveProgramming.Kattis.MassiveCardGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    static int LowerBound(long[] a, long value)
    {
        int lo = 0, hi = a.Length;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (a[mid] >= value)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }

    static int UpperBound(long[] a, long value)
    {
        int lo = 0, hi = a.Length;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (a[mid] > value)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }

    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        int n = int.Parse(nLine.Trim());
        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        long[] a = new long[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = long.Parse(parts[i]);
        }

        Array.Sort(a);

        string qLine = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(qLine)) qLine = Console.ReadLine();
        int q = int.Parse(qLine.Trim());

        while (q-- > 0)
        {
            string[] lr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (lr.Length < 2)
            {
                lr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            long l = long.Parse(lr[0]);
            long r = long.Parse(lr[1]);

            int lo = LowerBound(a, l);
            int hi = UpperBound(a, r);

            Console.WriteLine(hi - lo);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Massive Card Game");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}