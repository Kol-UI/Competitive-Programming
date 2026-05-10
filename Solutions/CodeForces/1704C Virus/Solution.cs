// Virus
namespace CompetitiveProgramming.CodeForces.Virus;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);
            
            string[] secondLine = Console.ReadLine().Split();
            List<long> f = new List<long>();
            for (long p = 0; p < m; p++)
            {
                f.Add(long.Parse(secondLine[p]));
            }
            f.Sort();
            
            List<long> g = new List<long>(new long[m]);
            g[0] = (n - f.Last() + f[0] - 1);
            for (long p = 1; p < m; p++)
            {
                g[(int)p] = f[(int)p] - f[(int)(p - 1)] - 1;
            }
            g.Sort((a, b) => b.CompareTo(a));
            
            long saved = 0;
            for (long p = 0; p < g.Count; p++)
            {
                long val = g[(int)p] - 4 * p;
                if (val == 1)
                {
                    saved++;
                }
                else if (val > 1)
                {
                    saved += (val - 1);
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine(n - saved);
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
        StyleHelper.Title("Virus");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}