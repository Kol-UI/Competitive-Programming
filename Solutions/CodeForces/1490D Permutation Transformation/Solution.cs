// Permutation Transformation
namespace CompetitiveProgramming.CodeForces.PermutationTransformation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void F(long start, long end, long curDepth, List<long> dv, List<long> depth)
    {
        if (start >= end) return;
        
        long idx = start;
        for (long p = start + 1; p < end; p++)
        {
            if (dv[(int)p] > dv[(int)idx])
                idx = p;
        }
        
        depth[(int)idx] = curDepth;
        F(start, idx, curDepth + 1, dv, depth);
        F(idx + 1, end, curDepth + 1, dv, depth);
    }
    
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<long> a = new List<long>();
            for (long p = 0; p < n; p++)
            {
                a.Add(long.Parse(input[p]));
            }
            
            List<long> res = new List<long>();
            for (long p = 0; p < n; p++) res.Add(0);
            
            F(0, n, 0, a, res);
            
            for (long p = 0; p < n; p++)
            {
                Console.Write($"{res[(int)p]} ");
            }
            Console.WriteLine();
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
        StyleHelper.Title("Permutation Transformation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}