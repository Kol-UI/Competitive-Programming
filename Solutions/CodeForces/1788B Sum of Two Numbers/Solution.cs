// Sum of Two Numbers
namespace CompetitiveProgramming.CodeForces.SumofTwoNumbers;
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
            long n = long.Parse(Console.ReadLine());
            long a = 0, b = 0, pow = 1;
            bool f = false;
            
            while(n > 0)
            {
                long x = n % 10;
                n /= 10;
                if(x % 2 == 1) f = !f;
                a += pow * ((x + (f ? 1 : 0)) / 2);
                b += pow * ((x + (f ? 0 : 1)) / 2);
                pow *= 10;
            }
            
            Console.WriteLine($"{a} {b}");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Two Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}