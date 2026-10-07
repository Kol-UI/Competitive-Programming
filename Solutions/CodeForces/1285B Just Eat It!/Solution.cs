// Just Eat It!
namespace CompetitiveProgramming.CodeForces.JustEatIt;
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

            long s = 0;
            bool ans = true;
            for (long p = 0; p < n; p++)
            {
                s += a[p];
                if (s <= 0) { ans = false; break; }
            }

            s = 0;
            for (long p = n - 1; p > 0; p--)
            {
                s += a[p];
                if (s <= 0) { ans = false; break; }
            }

            Console.WriteLine(ans ? "YES" : "NO");
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
        StyleHelper.Title("Just Eat It!");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}