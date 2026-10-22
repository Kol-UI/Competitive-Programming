// A Game in the Park
namespace CompetitiveProgramming.Kattis.AGameinthePark;
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
        const long mxN = 100005;

        long[][] grid = new long[4][];
        for (int i = 0; i < 4; i++) grid[i] = new long[mxN];

        long[][] dp = new long[16][];
        for (int i = 0; i < 16; i++) dp[i] = new long[mxN];

        long n = long.Parse(Console.ReadLine());

        for (int i = 0; i < 4; i++)
        {
            string[] vals = Console.ReadLine().Split();
            for (long j = 0; j < n; j++)
                grid[i][j] = long.Parse(vals[j]);
        }

        for (long i = 1; i <= n; i++)
        {
            for (long mask = 0; mask < (1 << 4); mask++)
            {
                if ((mask & (mask << 1)) > 0) continue;
                long smask = 0;
                for (long j = 0; j < 4; j++)
                {
                    if (((mask >> (int)j) & 1) == 1) smask += Math.Max(0L, grid[j][i - 1]);
                }
                for (long pmask = 0; pmask < (1 << 4); pmask++)
                {
                    if ((pmask & (pmask << 1)) > 0) continue;
                    if ((mask & pmask) > 0) continue;
                    dp[mask][i] = Math.Max(dp[mask][i], smask + dp[pmask][i - 1]);
                }
            }
        }

        long ans = 0;
        for (long i = 0; i < 16; i++) ans = Math.Max(ans, dp[i][n]);

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Game in the Park");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}