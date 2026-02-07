// Maximum Even Sum
namespace CompetitiveProgramming.CodeForces.MaximumEvenSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.IO;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        long t = long.Parse(Console.ReadLine());
        
        for(long i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = input[0];
            long b = input[1];
            
            long ans = -1;
            if(a % 2 == 1 && b % 2 == 1)
            {
                ans = a * b + 1;
            }
            else if(a % 2 == 1 && (b / 2) % 2 == 0)
            {
                ans = 2 + a * b / 2;
            }
            else if(a % 2 == 0 && b % 2 == 0)
            {
                ans = 2 + a * b / 2;
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Maximum Even Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}