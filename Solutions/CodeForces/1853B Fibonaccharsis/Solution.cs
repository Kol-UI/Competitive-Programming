// Fibonaccharsis
namespace CompetitiveProgramming.CodeForces.Fibonaccharsis;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<long> f = new List<long> { 0, 1 };
        while (f[f.Count - 1] < 10000000)
        {
            int n = f.Count;
            f.Add(f[n - 1] + f[n - 2]);
        }

        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);

            if (k >= f.Count)
            {
                Console.WriteLine("0");
                continue;
            }

            long a = f[(int)k - 2];
            long b = f[(int)k - 1];
            long cnt = 0;

            for (long u = 0; u < 1000000; u++)
            {
                long diff = n - a * u;
                if (diff < b * u) break;
                if (diff % b == 0) cnt++;
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Fibonaccharsis");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}