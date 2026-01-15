// GCD Length
namespace CompetitiveProgramming.CodeForces.GCDLength;
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
            long c = input[2];
            
            long Digits(long z)
            {
                long cnt = 0;
                while(z > 0)
                {
                    z /= 10;
                    ++cnt;
                }
                return cnt;
            }
            
            long g = 1;
            while(Digits(g) < c) g *= 2;
            
            long x = g;
            while(Digits(x) < a) x *= 3;
            
            long y = g;
            while(Digits(y) < b) y *= 5;
            
            Console.WriteLine($"{x} {y}");
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
        StyleHelper.Title("GCD Length");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}