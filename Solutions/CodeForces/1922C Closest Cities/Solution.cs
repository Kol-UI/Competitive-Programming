// Closest Cities
namespace CompetitiveProgramming.CodeForces.ClosestCities;
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
            long[] pos = new long[n];
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) pos[p] = long.Parse(vals[p]);

            long[] f = new long[n];
            long[] g = new long[n];
            f[0] = 1;
            g[n - 1] = 1;

            for (long p = 1; p + 1 < n; p++)
            {
                long prv = pos[p] - pos[p - 1];
                long nxt = pos[p + 1] - pos[p];
                if (prv < nxt) { f[p] = nxt; g[p] = 1; }
                else { f[p] = 1; g[p] = prv; }
            }

            for (long p = 1; p + 1 < n; p++) f[p] += f[p - 1];
            for (long p = n - 2; p > 0; p--) g[p] += g[p + 1];

            long m = long.Parse(Console.ReadLine());
            while (m-- > 0)
            {
                string[] ft = Console.ReadLine().Split();
                long from = long.Parse(ft[0]) - 1;
                long to = long.Parse(ft[1]) - 1;

                long res;
                if (from < to) res = f[to - 1] - (from > 0 ? f[from - 1] : 0);
                else res = g[to + 1] - ((from + 1 < n) ? g[from + 1] : 0);

                Console.WriteLine(res);
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
        StyleHelper.Title("Closest Cities");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}