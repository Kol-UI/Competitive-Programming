// Update Files
namespace CompetitiveProgramming.CodeForces.UpdateFiles;
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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long n = input[0];
            long k = input[1];
            
            long current = 1;
            long count = 0;
            
            while(current < n && current <= k)
            {
                current *= 2;
                count++;
            }
            
            if(current < n)
            {
                count += (n - current + k - 1) / k;
            }
            
            Console.WriteLine(count);
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
        StyleHelper.Title("Update Files");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}