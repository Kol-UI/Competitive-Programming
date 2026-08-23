// Cirno and Operations
namespace CompetitiveProgramming.CodeForces.CirnoandOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine() ?? "0");
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine() ?? "0");
            List<long> v = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long mx = 0;
            for (int p = 0; p < v.Count; p++)
            {
                mx += v[p];
            }

            while (v.Count > 1)
            {
                long total = 0;
                for (int p = 1; p < v.Count; p++)
                {
                    v[p - 1] = v[p] - v[p - 1];
                    total += v[p - 1];
                }
                total = Math.Abs(total);
                mx = Math.Max(mx, total);
                v.RemoveAt(v.Count - 1);
            }

            Console.WriteLine(mx);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cirno and Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}