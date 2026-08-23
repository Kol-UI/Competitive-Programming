// Even Larger
namespace CompetitiveProgramming.CodeForces.EvenLarger;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            long[] a = new long[n];
            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(input[p]);
            }

            long total = 0;
            for (long p = 1; p < n; p += 2)
            {
                if (a[p - 1] > a[p])
                {
                    total += a[p - 1] - a[p];
                    a[p - 1] = a[p];
                }
                if (p + 1 >= n) continue;

                if (a[p - 1] + a[p + 1] > a[p])
                {
                    long diff = a[p - 1] + a[p + 1] - a[p];
                    total += diff;
                    a[p + 1] -= diff;
                }
            }

            Console.WriteLine(total);
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
        StyleHelper.Title("Even Larger");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}