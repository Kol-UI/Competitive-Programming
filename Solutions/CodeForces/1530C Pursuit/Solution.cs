// Pursuit
namespace CompetitiveProgramming.CodeForces.Pursuit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static bool Check(long[] a, long[] b, long k)
    {
        long aSize = a.Length - 1;
        long bSize = b.Length - 1;

        long ra = (aSize + k) / 4;
        long rb = (bSize + k) / 4 - k;
        rb = rb > 0 ? rb : 0;

        long diff = 100 * k + (a[aSize] - a[(int)ra]) - (b[bSize] - b[(int)rb]);
        return diff >= 0;
    }

    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string nLine = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nLine)) nLine = Console.ReadLine();
            long n = long.Parse(nLine.Trim());

            string[] aParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (aParts.Length < n)
            {
                aParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string[] bParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (bParts.Length < n)
            {
                bParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            long[] a = new long[n + 1];
            long[] b = new long[n + 1];

            for (int p = 1; p <= n; p++)
            {
                a[p] = long.Parse(aParts[p - 1]);
                b[p] = long.Parse(bParts[p - 1]);
            }

            Array.Sort(a, 1, (int)n);
            Array.Sort(b, 1, (int)n);

            for (int p = 1; p <= n; p++)
            {
                a[p] += a[p - 1];
                b[p] += b[p - 1];
            }

            long left = 0, right = n + 1, res = 0;
            while (left <= right)
            {
                long mid = (left + right) / 2;
                if (Check(a, b, mid))
                {
                    res = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            Console.WriteLine(res);
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
        StyleHelper.Title("Pursuit");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}