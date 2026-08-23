// Yet Another MEX Problem
namespace CompetitiveProgramming.CodeForces.YetAnotherMEXProblem;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);

            bool[] v = new bool[k - 1];
            string[] input = Console.ReadLine().Split();

            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (x + 1 < k)
                    v[x] = true;
            }

            long mex = 0;
            while (mex < v.Length && v[mex])
                mex++;

            Console.WriteLine(mex);
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
        StyleHelper.Title("Yet Another MEX Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
