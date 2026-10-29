// 3SUM
namespace CompetitiveProgramming.CodeForces.ThreeSUM;
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
        const int B = 10;
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] cnt = new long[B];

            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(vals[p]);
                cnt[x % B]++;
            }

            bool res = false;

            for (long p = 0; !res && p < B; p++)
            {
                for (long q = p; !res && q < B; q++)
                {
                    for (long r = q; !res && r < B; r++)
                    {
                        if ((p + q + r) % 10 != 3) continue;
                        cnt[p]--; cnt[q]--; cnt[r]--;
                        if (cnt[p] >= 0 && cnt[q] >= 0 && cnt[r] >= 0) res = true;
                        cnt[p]++; cnt[q]++; cnt[r]++;
                    }
                }
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
        StyleHelper.Title("3SUM");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}