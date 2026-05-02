// Districts Connection
namespace CompetitiveProgramming.CodeForces.DistrictsConnection;
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
            long[] a = new long[n + 1];
            bool possible = false;
            List<long> first = new List<long>();
            List<long> second = new List<long>();
            
            for (long p = 1; p <= n; p++)
            {
                a[p] = long.Parse(input[p - 1]);
                if (a[p] != a[1])
                {
                    second.Add(p);
                    possible = true;
                }
                else
                {
                    first.Add(p);
                }
            }
            
            if (!possible)
            {
                Console.WriteLine("NO");
                continue;
            }
            
            Console.WriteLine("YES");
            
            long x = a[1];
            long cnt = 0;
            
            for (long p = 0; p < second.Count && cnt + 1 < n; p++, cnt++)
            {
                Console.WriteLine($"1 {second[(int)p]}");
            }
            
            for (long p = 1; p < first.Count && cnt + 1 < n; p++, cnt++)
            {
                Console.WriteLine($"{first[(int)p]} {second[0]}");
            }
            
            for (long p = 1; p < first.Count && cnt + 1 < n; p++, cnt++)
            {
                for (long q = 1; q < second.Count && cnt + 1 < n; q++, cnt++)
                {
                    Console.WriteLine($"{first[(int)p]} {second[(int)q]}");
                }
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
        StyleHelper.Title("Districts Connection");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}