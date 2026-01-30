// Binary Inversions
namespace CompetitiveProgramming.CodeForces.BinaryInversions;
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
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());
            long[] v = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long[] z = new long[n];
            long[] a = new long[n];
            long total = 0;
            
            for(long p = 0; p < n; p++)
            {
                z[p] = (p > 0 ? z[p - 1] : 0) + (v[p] == 0 ? 1 : 0);
                a[p] = (p > 0 ? a[p - 1] : 0) + (v[p] == 1 ? 1 : 0);
                if(v[p] == 0) total += a[p];
            }
            
            long mx = 0;
            for(long p = 0; p < n; p++)
            {
                long diff = (p > 0 ? a[p - 1] : 0) - (z[n - 1] - z[p]);
                if(v[p] == 0) diff = -diff;
                if(diff > mx) mx = diff;
            }
            
            Console.WriteLine(total + mx);
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
        StyleHelper.Title("Binary Inversions");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}