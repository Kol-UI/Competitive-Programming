// Large Addition
namespace CompetitiveProgramming.CodeForces.LargeAddition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            long x = long.Parse(Console.ReadLine());
            bool possible = true;
            
            if(x % 10 == 9) possible = false;
            x /= 10;
            
            while(possible && x > 9)
            {
                if(x % 10 == 0)
                {
                    possible = false;
                    break;
                }
                x /= 10;
            }
            
            possible = possible && (x == 1);
            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Large Addition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}