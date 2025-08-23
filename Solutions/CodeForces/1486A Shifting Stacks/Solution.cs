// Shifting Stacks
namespace CompetitiveProgramming.CodeForces.ShiftingStacks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] h = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long carry = 0;
            bool res = true;
            for (long p = 0; p < n; p++)
            {
                h[p] += carry;
                if (h[p] < p)
                {
                    res = false;
                    break;
                }
                carry = h[p] - p;
            }
            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Shifting Stacks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}