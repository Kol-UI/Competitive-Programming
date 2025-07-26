// Coprime
namespace CompetitiveProgramming.CodeForces.Coprime;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static long Gcd(long a, long b) => b == 0 ? a : Gcd(b, a % b);

    //static void Main()
    public static void MainSolution()
    {
        const int B = 1001;
        List<List<long>> m = new List<List<long>>(B);
        for (int p = 0; p < B; p++) m.Add(new List<long>());

        for (int p = 1; p < B; p++)
        {
            for (int q = 1; q < B; q++)
            {
                if (Gcd(p, q) > 1) continue;
                m[p].Add(q); m[q].Add(p);
            }
        }

        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            long[] where = new long[B];
            Array.Fill(where, -1);
            long[] nums = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            for (int p = 0; p < n; p++) where[nums[p]] = p + 1;

            long res = -1;
            for (int p = 1; p < B; p++)
            {
                if (where[p] < 0) continue;
                foreach (long q in m[p])
                {
                    if (where[q] < 0) continue;
                    long sum = where[p] + where[q];
                    res = Math.Max(res, sum);
                }
            }

            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Coprime");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}