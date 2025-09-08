// Chips on the Board
namespace CompetitiveProgramming.CodeForces.ChipsontheBoard;
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
            long n = long.Parse(Console.ReadLine());
            long sa = 0, sb = 0, ma = 1000000007, mb = 1000000007;
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in a)
            {
                ma = Math.Min(ma, x);
                sa += x;
            }
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in b)
            {
                mb = Math.Min(mb, x);
                sb += x;
            }
            long candA = sa + n * mb;
            long candB = sb + n * ma;
            Console.WriteLine(Math.Min(candA, candB));
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
        StyleHelper.Title("Chips on the Board");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}