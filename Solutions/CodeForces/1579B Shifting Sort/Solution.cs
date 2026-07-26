// Shifting Sort
namespace CompetitiveProgramming.CodeForces.ShiftingSort;
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
            long[] v = new long[n];
            for (long p = 0; p < n; p++)
            {
                v[p] = long.Parse(input[p]);
            }

            List<(long, long)> w = new List<(long, long)>();
            for (long p = 0; p < n; p++)
            {
                long idx = p;
                for (long q = p + 1; q < n; q++)
                {
                    if (v[q] < v[idx])
                    {
                        idx = q;
                    }
                }
                if (idx == p) continue;

                w.Add((p + 1, idx + 1));

                long temp = v[idx];
                for (long q = idx; q > p; q--)
                {
                    v[q] = v[q - 1];
                }
                v[p] = temp;
            }

            Console.WriteLine(w.Count);
            foreach (var (first, second) in w)
            {
                Console.WriteLine($"{first} {second} {second - first}");
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
        StyleHelper.Title("Shifting Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}