// Make Almost Equal With Mod
namespace CompetitiveProgramming.CodeForces.MakeAlmostEqualWithMod;
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
            long[] a = new long[n];
            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(input[p]);
            }

            long mod = 0;
            for (long pow2 = 2; mod == 0 && pow2 < 3e18; pow2 *= 2)
            {
                HashSet<long> s = new HashSet<long>();
                for (long p = 0; s.Count < 3 && p < n; p++)
                {
                    s.Add(a[p] % pow2);
                }
                if (s.Count == 2)
                {
                    mod = pow2;
                    break;
                }
            }

            Console.WriteLine(mod);
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
        StyleHelper.Title("Make Almost Equal With Mod");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}