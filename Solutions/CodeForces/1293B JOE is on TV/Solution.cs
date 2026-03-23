// JOE is on TV!
namespace CompetitiveProgramming.CodeForces.JOEisonTV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        long n = long.Parse(Console.ReadLine());
        
        double result = 0.0;
        for(long p = 1; p <= n; p++)
        {
            result += 1.0 / p;
        }
        
        Console.WriteLine($"{result:F5}");
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("JOE is on TV!");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}