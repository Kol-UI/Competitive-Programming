// Make it Zigzag
namespace CompetitiveProgramming.CodeForces.MakeitZigzag;
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
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long[] maxSoFar = new long[n];
            maxSoFar[0] = a[0];
            for(int p = 1; p < n; p++)
            {
                maxSoFar[p] = Math.Max(maxSoFar[p - 1], a[p]);
            }
            
            long total = 0;
            for(int p = 0; p < n; p += 2)
            {
                long diff = -1;
                if(p > 0) diff = Math.Max(diff, a[p] - maxSoFar[p - 1]);
                if(p + 1 < n) diff = Math.Max(diff, a[p] - maxSoFar[p + 1]);
                total += diff + 1;
            }
            
            Console.WriteLine(total);
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
        StyleHelper.Title("Make it Zigzag");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}