// Sweet Problem
namespace CompetitiveProgramming.CodeForces.SweetProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            List<long> a = new List<long>
            {
                long.Parse(input[0]),
                long.Parse(input[1]),
                long.Parse(input[2])
            };

            a.Sort();

            long ans;
            if (a[2] > a[0] + a[1])
                ans = a[0] + a[1];
            else
                ans = (a[0] + a[1] + a[2]) / 2;

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
        StyleHelper.Title("Sweet Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
