// Boxes Packing
namespace CompetitiveProgramming.CodeForces.BoxesPacking;
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
        long n = long.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        Dictionary<long, long> m = new Dictionary<long, long>();
        long mc = 0;

        for (long p = 0; p < n; p++)
        {
            long x = long.Parse(input[p]);
            if (!m.ContainsKey(x))
                m[x] = 0;
            m[x]++;
            if (m[x] > mc)
                mc = m[x];
        }

        Console.WriteLine(mc);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Boxes Packing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}