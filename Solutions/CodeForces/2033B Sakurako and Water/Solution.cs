// Sakurako and Water
namespace CompetitiveProgramming.CodeForces.SakurakoandWater;
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
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            List<long> v = new List<long>(new long[2 * n - 1]);
            for (long row = 0; row < n; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (long col = 0; col < n; col++)
                {
                    long x = long.Parse(line[col]);
                    long idx = (n - 1) + row - col;
                    v[(int)idx] = Math.Max(v[(int)idx], -x);
                }
            }
            long total = 0;
            for (long p = 0; p < v.Count; p++) total += v[(int)p];
            Console.WriteLine(total);
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
        StyleHelper.Title("Sakurako and Water");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}