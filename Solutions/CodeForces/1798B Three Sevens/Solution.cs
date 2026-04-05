// Three Sevens
namespace CompetitiveProgramming.LeetCode.ThreeSevens;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        const long N = 50007;
        long t = long.Parse(Console.ReadLine());
        
        while (t-- > 0)
        {
            long m = long.Parse(Console.ReadLine());
            List<List<long>> v = new List<List<long>>();
            
            for (long p = 0; p < m; p++)
            {
                long n = long.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                List<long> list = new List<long>();
                
                for (long u = 0; u < n; u++)
                {
                    long x = long.Parse(input[u]);
                    list.Add(x);
                }
                v.Add(list);
            }
            
            bool[] f = new bool[N];
            List<long> w = new List<long>();
            for (long p = 0; p < m; p++)
            {
                w.Add(-1);
            }
            
            for (long p = m - 1; p >= 0; p--)
            {
                for (long u = 0; u < v[(int)p].Count; u++)
                {
                    long x = v[(int)p][(int)u];
                    if (!f[x] && w[(int)p] < 0)
                    {
                        w[(int)p] = x;
                    }
                    f[x] = true;
                }
                if (w[(int)p] < 0)
                {
                    break;
                }
            }
            
            if (w[0] < 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                for (long p = 0; p < m; p++)
                {
                    Console.Write($"{w[(int)p]} ");
                }
                Console.WriteLine();
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
        StyleHelper.Title("Three Sevens");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}