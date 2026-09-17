// Production of Snowmen
namespace CompetitiveProgramming.CodeForces.ProductionofSnowmen;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine().Trim());

            string[] aParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] a = new long[n];
            for (int i = 0; i < n; i++) a[i] = long.Parse(aParts[i]);

            string[] bParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] b = new long[n];
            for (int i = 0; i < n; i++) b[i] = long.Parse(bParts[i]);

            string[] cParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] c = new long[n];
            for (int i = 0; i < n; i++) c[i] = long.Parse(cParts[i]);

            long cnt = 0;
            for (int bs = 0; bs < n; bs++)
            {
                bool valid = true;
                for (int p = 0; valid && p < n; p++)
                {
                    if (a[p] >= b[(bs + p) % n]) valid = false;
                }
                cnt += n * (valid ? 1 : 0);
            }

            long prev = cnt;
            cnt = 0;
            for (int cs = 0; cs < n; cs++)
            {
                bool valid = true;
                for (int p = 0; valid && p < n; p++)
                {
                    if (b[p] >= c[(cs + p) % n]) valid = false;
                }
                cnt += prev * (valid ? 1 : 0);
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Production of Snowmen");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}