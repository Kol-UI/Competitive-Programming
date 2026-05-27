// Turtle Tenacity: Continual Mods
namespace CompetitiveProgramming.CodeForces.TurtleTenacityContinualMods;
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
            
            long mn = 1000000007;
            long cnt = 0;
            List<long> a = new List<long>();
            
            for (long p = 0; p < n; p++)
            {
                long val = long.Parse(input[p]);
                a.Add(val);
                if (val < mn)
                {
                    mn = val;
                    cnt = 1;
                }
                else if (val == mn)
                {
                    cnt++;
                }
            }
            
            if (cnt == 1)
            {
                Console.WriteLine("YES");
                continue;
            }
            
            bool sm = false;
            for (long p = 0; !sm && p < n; p++)
            {
                if (a[(int)p] % mn != 0)
                {
                    sm = true;
                }
            }
            
            Console.WriteLine(sm ? "YES" : "NO");
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
        StyleHelper.Title("Turtle Tenacity: Continual Mods");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}