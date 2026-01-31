// Alyona and Numbers
namespace CompetitiveProgramming.CodeForces.AlyonaandNumbers;
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
        const int D = 5;
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long n = input[0];
        long m = input[1];
        
        long[] a = new long[D];
        long[] b = new long[D];
        
        a[0] = n / D;
        b[0] = m / D;
        
        for(int p = 1; p < D; p++)
        {
            a[p] = (n / D) + (n % D >= p ? 1 : 0);
            b[p] = (m / D) + (m % D >= p ? 1 : 0);
        }
        
        long res = 0;
        for(int p = 0; p < D; p++)
        {
            res += a[p] * b[(D - p) % D];
        }
        
        Console.WriteLine(res);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alyona and Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}