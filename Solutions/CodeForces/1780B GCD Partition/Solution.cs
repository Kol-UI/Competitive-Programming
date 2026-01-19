// GCD Partition
namespace CompetitiveProgramming.CodeForces.GCDPartition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

public class Solution
{
    static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
    
    static public void Main()
    {
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long[] left = new long[n];
            for(long p = 0; p < n; p++)
            {
                left[p] = a[p] + (p > 0 ? left[p - 1] : 0);
            }
            
            long[] right = new long[n];
            for(long p = n - 1; p >= 0; p--)
            {
                right[p] = a[p] + (p + 1 < n ? right[p + 1] : 0);
            }
            
            long res = 0;
            for(long p = 1; p < n; p++)
            {
                long g = Gcd(left[p - 1], right[p]);
                if(g > res) res = g;
            }
            
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
        StyleHelper.Title("GCD Partition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}