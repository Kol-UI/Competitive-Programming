// Monsters (easy version)
namespace CompetitiveProgramming.CodeForces.Monsterseasyversion;
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
            List<long> h = new List<long>();
            for (long p = 0; p < n; p++)
            {
                h.Add(long.Parse(input[p]));
            }
            h.Sort();
            
            long cnt = 0;
            for (long p = 0; p < n; p++)
            {
                long prev = (p > 0) ? h[(int)(p - 1)] : 0;
                if (h[(int)p] > prev + 1)
                {
                    cnt += h[(int)p] - (prev + 1);
                    h[(int)p] = prev + 1;
                }
            }
            
            Console.WriteLine(cnt);
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
        StyleHelper.Title("Monsters (easy version)");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}