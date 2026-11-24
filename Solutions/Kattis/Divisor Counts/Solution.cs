// Divisor Counts
namespace CompetitiveProgramming.Kattis.DivisorCounts;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Text;

class Solution
{
    static void Main()
    {
        const int mxN = 3000006;
        long[] ans = new long[mxN];

        long n = long.Parse(Console.ReadLine());

        for (long i = 1; i <= n; i++)
        {
            for (long j = i; j <= n; j += i)
            {
                ans[j]++;
            }
        }

        StringBuilder sb = new StringBuilder();
        for (long i = 1; i <= n; i++)
        {
            sb.Append(ans[i]).Append('\n');
        }

        Console.Write(sb.ToString());
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Divisor Counts");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}