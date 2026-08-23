// Stalin Sort
namespace CompetitiveProgramming.CodeForces.StalinSort;
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
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<long> v = new List<long>();
            for (long p = 0; p < n; p++)
            {
                v.Add(long.Parse(input[p]));
            }

            long mxlen = 0;
            for (long p = 0; p < n; p++)
            {
                long cnt = 1;
                for (long q = p + 1; q < n; q++)
                {
                    if (v[(int)q] <= v[(int)p]) cnt++;
                }
                if (cnt > mxlen) mxlen = cnt;
            }

            Console.WriteLine(n - mxlen);
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
        StyleHelper.Title("Stalin Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}