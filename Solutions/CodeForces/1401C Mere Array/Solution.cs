// Mere Array
namespace CompetitiveProgramming.CodeForces.MereArray;
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
            long[] b = new long[n];
            long mn = 1000000007;

            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(vals[p]);
                a[p] = x;
                b[p] = x;
                if (x < mn) mn = x;
            }

            Array.Sort(b);

            bool res = true;
            for (long p = 0; p < n; p++)
            {
                if (a[p] == b[p]) continue;
                if (a[p] % mn == 0) continue;
                res = false;
                break;
            }

            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Mere Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}