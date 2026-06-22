// Make Equal With Mod
namespace CompetitiveProgramming.CodeForces.MakeEqualWithMod;
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
            List<long> a = new List<long>();
            bool one = false;
            
            for (long p = 0; p < n; p++)
            {
                long val = long.Parse(input[p]);
                a.Add(val);
                if (val == 1) one = true;
            }
            
            a.Sort();
            bool res = true;
            
            if (one)
            {
                for (long p = 1; res && p < n; p++)
                {
                    if (a[(int)p] == 1 + a[(int)(p - 1)])
                    {
                        res = false;
                        break;
                    }
                }
            }
            
            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Make Equal With Mod");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}