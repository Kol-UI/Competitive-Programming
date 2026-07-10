// Playing with GCD
namespace CompetitiveProgramming.CodeForces.PlayingwithGCD;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<long> a = new List<long>();
            for (long p = 0; p < n; p++)
            {
                a.Add(long.Parse(input[p]));
            }
            
            bool res = true;
            for (long p = 1; res && p + 1 < n; p++)
            {
                if (a[(int)p] % Gcd(a[(int)(p - 1)], a[(int)(p + 1)]) != 0)
                {
                    res = false;
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
        StyleHelper.Title("Playing with GCD");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}