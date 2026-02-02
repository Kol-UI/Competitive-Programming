// Count Good Numbers
namespace CompetitiveProgramming.CodeForces.CountGoodNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static long GetCount(long x, long LCM, long seg_cnt)
    {
        long cnt = (x / LCM) * seg_cnt;
        x %= LCM;
        for(long p = 1; p <= x; p++)
        {
            if(p % 2 != 0 && p % 3 != 0 && p % 5 != 0 && p % 7 != 0)
            {
                cnt++;
            }
        }
        return cnt;
    }
    
    static public void Main()
    {
        const long L = 210;
        long g = 0;
        for(long p = 1; p < L; p++)
        {
            if(p % 2 != 0 && p % 3 != 0 && p % 5 != 0 && p % 7 != 0)
            {
                g++;
            }
        }
        
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = input[0];
            long b = input[1];
            
            long res = GetCount(b, L, g) - GetCount(a - 1, L, g);
            Console.WriteLine(res);
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
        StyleHelper.Title("Count Good Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}