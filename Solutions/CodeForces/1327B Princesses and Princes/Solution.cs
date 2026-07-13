// Princesses and Princes
namespace CompetitiveProgramming.CodeForces.PrincessesandPrinces;
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
            bool[] taken = new bool[n + 1];
            long x = -1, y = -1;

            for (long p = 1; p <= n; p++)
            {
                string[] input = Console.ReadLine().Split();
                long m = long.Parse(input[0]);
                bool married = false;

                for (long u = 0; u < m; u++)
                {
                    long cand = long.Parse(input[u + 1]);
                    if (married || taken[cand]) continue;
                    married = true;
                    taken[cand] = true;
                }

                if (!married) x = p;
            }

            if (x < 0)
            {
                Console.WriteLine("OPTIMAL");
            }
            else
            {
                for (long p = 1; p <= n; p++)
                {
                    if (!taken[p])
                    {
                        y = p;
                        break;
                    }
                }
                Console.WriteLine($"IMPROVE\n{x} {y}");
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
        StyleHelper.Title("Princesses and Princes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}