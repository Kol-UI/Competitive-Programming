// Maximize Mex
namespace CompetitiveProgramming.CodeForces.MaximizeMex;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long x = long.Parse(firstLine[1]);

            long[] v = new long[n + 1];
            string[] input = Console.ReadLine().Split();

            for (long p = 0; p < n; p++)
            {
                long b = long.Parse(input[p]);
                if (b < n)
                    v[b]++;
            }

            long mex = n;
            for (long p = 0; p < n; p++)
            {
                if (v[p] == 0)
                {
                    mex = p;
                    break;
                }
                if (p + x < n)
                    v[p + x] += v[p] - 1;
            }

            Console.WriteLine(mex);
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
        StyleHelper.Title("Maximize Mex");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}