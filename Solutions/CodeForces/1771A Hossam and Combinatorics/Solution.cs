// Hossam and Combinatorics
namespace CompetitiveProgramming.CodeForces.HossamandCombinatorics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
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
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long mx = 0, cmx = 0, mn = 1000000, cmn = 0;
            foreach (long x in arr)
            {
                if (x > mx)
                {
                    mx = x;
                    cmx = 1;
                }
                else if (x == mx) cmx++;

                if (x < mn)
                {
                    mn = x;
                    cmn = 1;
                }
                else if (x == mn) cmn++;
            }
            long ans = mn < mx ? 2 * cmn * cmx : (n - 1) * n;
            Console.WriteLine(ans);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hossam and Combinatorics");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}