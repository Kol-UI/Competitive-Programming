// Dominated Subarray
namespace CompetitiveProgramming.CodeForces.DominatedSubarray;
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
            
            long res = -1;
            Dictionary<long, long> f = new Dictionary<long, long>();
            
            for (long p = 0; p < n; p++)
            {
                long a = long.Parse(input[p]);
                if (f.ContainsKey(a))
                {
                    long dist = p - f[a] + 1;
                    if (res < 0 || dist < res)
                        res = dist;
                }
                f[a] = p;
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
        StyleHelper.Title("Dominated Subarray");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}