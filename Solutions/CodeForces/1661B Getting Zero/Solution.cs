// Getting Zero
namespace CompetitiveProgramming.CodeForces.GettingZero;
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
        const long B = 15;
        const long MOD = 32768;

        long n = long.Parse(Console.ReadLine());
        string[] vals = Console.ReadLine().Split();

        for (long i = 0; i < n; i++)
        {
            long res = 100;
            long x = long.Parse(vals[i]);

            for (long p = 0; p <= B; p++)
            {
                long y = x + p;
                for (long q = 0; q <= B; q++)
                {
                    long steps = p + q;
                    if (y % MOD == 0 && steps < res) res = steps;
                    y *= 2;
                }
            }

            Console.Write(res + " ");
        }

        Console.WriteLine();
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Getting Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}