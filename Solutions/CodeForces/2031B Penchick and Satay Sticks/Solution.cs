// Penchick and Satay Sticks
namespace CompetitiveProgramming.CodeForces.PenchickandSataySticks;
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
            long[] v = new long[n + 1];
            string[] input = Console.ReadLine().Split();
            for (long p = 1; p <= n; p++) v[p] = long.Parse(input[p - 1]);
            bool ans = true;
            for (long p = 1; p <= n && ans; p++)
            {
                if (v[p] == p) continue;
                else if (v[p] == p + 1 && p < n && v[p + 1] == p)
                {
                    long tmp = v[p];
                    v[p] = v[p + 1];
                    v[p + 1] = tmp;
                }
                else ans = false;
            }
            Console.WriteLine(ans ? "YES" : "NO");
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
        StyleHelper.Title("Penchick and Satay Sticks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}