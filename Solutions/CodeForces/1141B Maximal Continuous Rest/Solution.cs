// Maximal Continuous Rest
namespace CompetitiveProgramming.CodeForces.MaximalContinuousRest;
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
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int cnt = 0, mx = 0;
        for (int p = 0; p < 2 * n; p++)
        {
            if (a[p % n] == 1)
            {
                cnt++;
                mx = Math.Max(mx, cnt);
            }
            else
            {
                cnt = 0;
            }
        }
        Console.WriteLine(mx);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximal Continuous Rest");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}