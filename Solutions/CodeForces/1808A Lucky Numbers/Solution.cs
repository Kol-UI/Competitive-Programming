// Lucky Numbers
namespace CompetitiveProgramming.CodeForces.LuckyNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static int Check(long x)
    {
        int mn = 9, mx = 0;
        while (x > 0)
        {
            int d = (int)(x % 10);
            x /= 10;
            mn = Math.Min(mn, d);
            mx = Math.Max(mx, d);
        }
        return mx - mn;
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long left = long.Parse(input[0]);
            long right = long.Parse(input[1]);
            long res = left, val = 0;
            for (long p = left; p <= right && p <= left + 200; p++)
            {
                int tst = Check(p);
                if (tst > val)
                {
                    val = tst;
                    res = p;
                }
            }
            Console.WriteLine(res);
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
        StyleHelper.Title("Lucky Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}