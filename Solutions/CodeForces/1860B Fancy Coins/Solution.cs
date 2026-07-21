// Fancy Coins
namespace CompetitiveProgramming.CodeForces.FancyCoins;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long m = long.Parse(input[0]);
            long k = long.Parse(input[1]);
            long a = long.Parse(input[2]);
            long b = long.Parse(input[3]);

            long x = m / k;
            long rs = m % k;

            long fs = rs - a;
            if (fs < 0) fs = 0;

            long ls = a - rs;
            if (ls < 0) ls = 0;

            long fk = x - b;
            if (fk < 0) fk = 0;

            long usedK = (ls / k < fk) ? (ls / k) : fk;
            long cnt = fs + fk - usedK;

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Fancy Coins");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}