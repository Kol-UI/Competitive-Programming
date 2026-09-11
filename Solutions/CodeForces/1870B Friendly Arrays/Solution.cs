// Friendly Arrays
namespace CompetitiveProgramming.CodeForces.FriendlyArrays;
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
            string[] nm = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(nm[0]);
            long m = long.Parse(nm[1]);

            string[] aParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] a = new long[n];
            for (int p = 0; p < n; p++)
            {
                a[p] = long.Parse(aParts[p]);
            }

            string[] bParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] b = new long[m];
            for (int p = 0; p < m; p++)
            {
                b[p] = long.Parse(bParts[p]);
            }

            long A = 0;
            for (int p = 0; p < n; p++)
            {
                A ^= a[p];
            }

            if (n % 2 != 0)
            {
                long mx = A;
                for (int p = 0; p < m; p++)
                {
                    mx |= b[p];
                }
                Console.WriteLine($"{A} {mx}");
            }
            else
            {
                long mn = A;
                for (int p = 0; p < m; p++)
                {
                    mn &= ~b[p];
                }
                Console.WriteLine($"{mn} {A}");
            }
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
        StyleHelper.Title("Friendly Arrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}