// Maximum Sum
namespace CompetitiveProgramming.CodeForces.BMaximumSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        const long MOD = 1000000007L;
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            var firstLine = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = firstLine[0];
            long k = firstLine[1];
            
            long[] x = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long cur = 0, mx = 0, total = 0;
            for(long p = 0; p < n; p++)
            {
                total += x[p];
                cur += x[p];
                if(cur < 0) cur = 0;
                if(cur > mx) mx = cur;
            }
            
            total -= mx;
            total = (total % MOD + MOD) % MOD;
            
            while(k-- > 0)
            {
                mx = (mx * 2) % MOD;
            }
            
            long result = (total + mx) % MOD;
            Console.WriteLine(result);
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
        StyleHelper.Title("Maximum Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}