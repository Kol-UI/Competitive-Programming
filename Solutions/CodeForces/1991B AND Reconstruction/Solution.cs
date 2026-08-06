// AND Reconstruction
namespace CompetitiveProgramming.CodeForces.ANDReconstruction;
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

            long[] b = new long[n + 1];
            for (long p = 1; p < n; p++)
            {
                b[p] = long.Parse(input[p - 1]);
            }

            long[] a = new long[n];
            for (long p = 0; p < n; p++)
            {
                a[p] = b[p] | b[p + 1];
            }

            bool possible = true;
            for (long p = 1; possible && p < n; p++)
            {
                if ((a[p - 1] & a[p]) != b[p])
                {
                    possible = false;
                }
            }

            if (!possible)
            {
                Console.WriteLine("-1");
                continue;
            }

            for (long p = 0; p < n; p++)
            {
                Console.Write($"{a[p]} ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("AND Reconstruction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}