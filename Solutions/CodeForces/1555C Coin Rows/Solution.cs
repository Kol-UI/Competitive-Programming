// Coin Rows
namespace CompetitiveProgramming.CodeForces.CoinRows;
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
            long[,] f = new long[2, n];

            for (long row = 0; row < 2; row++)
            {
                string[] vals = Console.ReadLine().Split();
                for (long col = 0; col < n; col++)
                    f[row, col] = long.Parse(vals[col]);
            }

            for (long p = n - 2; p >= 0; p--)
                f[0, p] += f[0, p + 1];
            for (long p = 1; p < n; p++)
                f[1, p] += f[1, p - 1];

            long res = 2000000000;
            for (long p = 0; p < n; p++)
            {
                long u = (p + 1 < n) ? f[0, p + 1] : 0;
                long v = (p > 0) ? f[1, p - 1] : 0;
                long w = (u > v) ? u : v;
                if (w < res) res = w;
            }

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
        StyleHelper.Title("Coin Rows");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}