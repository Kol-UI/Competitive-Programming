// Blackslex and Number Theory
namespace CompetitiveProgramming.CodeForces.BlackslexandNumberTheory;
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
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long min1 = 1000000007;
            long min2 = 1000000007;
            
            foreach(long x in numbers)
            {
                if(x < min1)
                {
                    min2 = min1;
                    min1 = x;
                }
                else if(x < min2)
                {
                    min2 = x;
                }
            }
            
            long result = min2 - min1;
            if(result < min1) result = min1;
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Blackslex and Number Theory");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}