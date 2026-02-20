// Perfecto
namespace CompetitiveProgramming.CodeForces.Perfecto;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        HashSet<long> squares = new HashSet<long>();
        for(long p = 1; p <= 500000; p++)
        {
            squares.Add(p * p);
        }
        
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());
            long total = n * (n + 1) / 2;
            if(squares.Contains(total))
            {
                Console.WriteLine(-1);
                continue;
            }
            
            long[] v = new long[n];
            for(long p = 0; p < n; p++) v[p] = -1;
            
            long cs = 0;
            for(long p = 0; p < n; p++)
            {
                if(v[p] < 0)
                {
                    long cur = p + 1;
                    if(squares.Contains(cs + cur))
                    {
                        v[p] = cur + 1;
                        if(p + 1 < n) v[p + 1] = cur;
                    }
                    else
                    {
                        v[p] = cur;
                    }
                }
                cs += v[p];
            }
            
            Console.WriteLine(string.Join(" ", v.Select(x => x.ToString()).ToArray()));
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Perfecto");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}