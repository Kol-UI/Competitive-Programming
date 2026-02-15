// Increase and Copy
namespace CompetitiveProgramming.CodeForces.IncreaseandCopy;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        const long R = 10;
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());
            long s = (long)Math.Sqrt(n);
            
            long lb = s >= R + 1 ? s - R : 1;
            long ub = s + R;
            
            long res = n + 1;
            for(long p = lb; p <= ub; p++)
            {
                long test = (p - 1) + (n + p - 1) / p - 1;
                if(test < res) res = test;
            }
            
            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Increase and Copy");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}