// Elementary Particles
namespace CompetitiveProgramming.CodeForces.ElementaryParticles;
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

            Dictionary<long, long> pos = new Dictionary<long, long>();
            long md = n + 1;

            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (pos.ContainsKey(x))
                {
                    long diff = p - pos[x];
                    if (diff < md) md = diff;
                }
                pos[x] = p;
            }

            Console.WriteLine(n - md);
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
        StyleHelper.Title("Elementary Particles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
