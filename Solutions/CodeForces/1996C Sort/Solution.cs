// Sort
namespace CompetitiveProgramming.CodeForces.Sort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long q = long.Parse(firstLine[1]);
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            long[][] va = new long[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                va[i] = new long[26];
            }

            for (long p = 0; p < n; p++)
            {
                for (long u = 0; u < 26; u++)
                {
                    va[p + 1][u] = va[p][u];
                }
                va[p + 1][a[(int)p] - 'a']++;
            }

            long[][] vb = new long[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                vb[i] = new long[26];
            }

            for (long p = 0; p < n; p++)
            {
                for (long u = 0; u < 26; u++)
                {
                    vb[p + 1][u] = vb[p][u];
                }
                vb[p + 1][b[(int)p] - 'a']++;
            }

            while (q-- > 0)
            {
                string[] range = Console.ReadLine().Split();
                long left = long.Parse(range[0]);
                long right = long.Parse(range[1]);

                long total = 0;
                for (long p = 0; p < 26; p++)
                {
                    long ca = va[right][p] - va[left - 1][p];
                    long cb = vb[right][p] - vb[left - 1][p];
                    long diff = cb - ca;
                    if (diff < 0) diff = -diff;
                    total += diff;
                }

                Console.WriteLine(total / 2);
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}