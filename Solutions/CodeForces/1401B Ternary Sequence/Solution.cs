// Ternary Sequence
namespace CompetitiveProgramming.CodeForces.TernarySequence;
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
            long[] x = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] y = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long res = 0;
            long min = Math.Min(x[2], y[1]);
            res += 2 * min;
            x[2] -= min;
            y[1] -= min;
            
            min = Math.Min(x[2], y[2]);
            x[2] -= min;
            y[2] -= min;
            
            min = Math.Min(x[2], y[0]);
            x[2] -= min;
            y[0] -= min;
            
            min = Math.Min(x[0], y[2]);
            x[0] -= min;
            y[2] -= min;
            
            min = Math.Min(x[1], y[2]);
            res -= 2 * min;
            x[1] -= min;
            y[2] -= min;
            
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
        StyleHelper.Title("Ternary Sequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}