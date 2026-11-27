// Array Recoloring
namespace CompetitiveProgramming.CodeForces.ArrayRecoloring;
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
            long mxmid = -1;

            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(vals[p]);
                if (k > 1) continue;
                if (p > 0 && p + 1 < n) mxmid = (mxmid > a[p] ? mxmid : a[p]);
            }

            if (k == 1 && n > 2)
            {
                long left = a[0] + mxmid;
                long right = mxmid + a[n - 1];
                long both = a[0] + a[n - 1];
                long res = (left > right ? left : right);
                res = (res > both ? res : both);
                Console.WriteLine(res);
                continue;
            }

            Array.Sort(a);
            Array.Reverse(a);

            long total = 0;
            for (long p = 0; p < n && p < k + 1; p++) total += a[p];
            Console.WriteLine(total);
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
        StyleHelper.Title("Array Recoloring");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}