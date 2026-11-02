// Common Divisors
namespace CompetitiveProgramming.CodeForces.CommonDivisors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static long Gcd(long a, long b) => b == 0 ? a : Gcd(b, a % b);

    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long g = 0;

        string[] vals = Console.ReadLine().Split();
        for (long p = 0; p < n; p++)
        {
            long x = long.Parse(vals[p]);
            g = Gcd(g, x);
        }

        long cnt = 0;
        for (long p = 1; p * p <= g; p++)
        {
            if (g % p != 0) continue;
            cnt += 1 + (p * p != g ? 1 : 0);
        }

        Console.WriteLine(cnt);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Common Divisors");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}