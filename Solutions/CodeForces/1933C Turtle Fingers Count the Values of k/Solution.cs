// Turtle Fingers: Count the Values of k
namespace CompetitiveProgramming.CodeForces.TurtleFingersCounttheValuesofk;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = input[0];
            long b = input[1];
            long g = input[2];
            
            long divisor = 1;
            HashSet<long> set = new HashSet<long>();
            
            while(g % divisor == 0)
            {
                long current = g / divisor;
                set.Add(current);
                
                while(current % a == 0)
                {
                    set.Add(current / a);
                    current /= a;
                }
                
                divisor *= b;
            }
            
            Console.WriteLine(set.Count);
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
        StyleHelper.Title("Turtle Fingers: Count the Values of k");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}