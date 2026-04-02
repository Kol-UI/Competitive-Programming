// Minimum Integer
namespace CompetitiveProgramming.CodeForces.MinimumInteger;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long q = long.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long l = long.Parse(input[0]);
            long r = long.Parse(input[1]);
            long d = long.Parse(input[2]);
            
            long ans = d;
            if (l <= d && d <= r)
            {
                ans = d * (1 + (r / d));
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
        StyleHelper.Title("Minimum Integer");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}