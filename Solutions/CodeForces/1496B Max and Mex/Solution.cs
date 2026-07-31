// Max and Mex
namespace CompetitiveProgramming.CodeForces.MaxandMex;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);

            string[] input = Console.ReadLine().Split();
            HashSet<long> s = new HashSet<long>();
            long max = 0;

            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                s.Add(x);
                if (x > max) max = x;
            }

            if (max == n - 1)
            {
                Console.WriteLine(n + k);
                continue;
            }

            long mex = 0;
            for (long p = 0; p < 1000000007; p++)
            {
                if (!s.Contains(p))
                {
                    mex = p;
                    break;
                }
            }

            long u = (max + mex + 1) / 2;
            long add = (k > 0 && !s.Contains(u)) ? 1 : 0;
            Console.WriteLine(s.Count + add);
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
        StyleHelper.Title("Max and Mex");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}