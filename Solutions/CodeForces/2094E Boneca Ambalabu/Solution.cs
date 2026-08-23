// Boneca Ambalabu
namespace CompetitiveProgramming.CodeForces.BonecaAmbalabu;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        const int B = 35;
        long t = long.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            long[] a = new long[n];
            long[] v = new long[B];

            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(input[p]);
                long x = a[p];

                for (long b = 0; x != 0 && b < B; b++)
                {
                    v[b] += x % 2;
                    x /= 2;
                }
            }

            long mx = 0;

            for (long p = 0; p < n; p++)
            {
                long x = a[p];
                long total = 0;

                for (long b = 0; b < B; b++)
                {
                    long bit = x % 2;
                    total += (1L << (int)b) * (bit != 0 ? (n - v[b]) : v[b]);
                    x /= 2;
                }

                if (total > mx) mx = total;
            }

            Console.WriteLine(mx);
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
        StyleHelper.Title("Boneca Ambalabu");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}