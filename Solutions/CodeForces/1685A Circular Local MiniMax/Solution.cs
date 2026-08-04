// Circular Local MiniMax
namespace CompetitiveProgramming.CodeForces.CircularLocalMiniMax;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<long> a = new List<long>();
            for (long p = 0; p < n; p++)
            {
                a.Add(long.Parse(input[p]));
            }

            if (n % 2 == 1)
            {
                Console.WriteLine("NO");
                continue;
            }

            a.Sort();
            long[] b = new long[n];

            for (long p = 0; p < n; p++)
            {
                long idx = (2 * p + (2 * p >= n ? 1 : 0)) % n;
                b[idx] = a[(int)p];
            }

            bool possible = true;
            for (long p = 0; possible && p < n; p++)
            {
                long prev = (p - 1 + n) % n;
                long next = (p + 1) % n;

                if (b[prev] <= b[p] && b[p] <= b[next])
                    possible = false;
                if (b[prev] >= b[p] && b[p] >= b[next])
                    possible = false;
            }

            if (!possible)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
                for (long p = 0; p < n; p++)
                {
                    Console.Write($"{b[p]} ");
                }
                Console.WriteLine();
            }
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
        StyleHelper.Title("Circular Local MiniMax");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}