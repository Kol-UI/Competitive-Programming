// Make it Alternating
namespace CompetitiveProgramming.CodeForces.MakeitAlternating;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        const long MOD = 998244353;

        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine() + "_";
            long cnt = 1, sum = 0, prod = 1;
            for (long p = 1; p < s.Length; p++)
            {
                if (s[(int)(p - 1)] == s[(int)p]) { cnt++; continue; }
                sum += (cnt - 1);
                prod = (prod * cnt) % MOD;
                cnt = 1;
            }

            for (int p = 2; p <= sum; p++) prod = (prod * p) % MOD;

            Console.WriteLine(sum + " " + prod);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make it Alternating");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}