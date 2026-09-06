// Social running
namespace CompetitiveProgramming.Kattis.Socialrunning;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        int n = int.Parse(nLine.Trim());
        int[] dst = new int[n];
        for (int i = 0; i < n; i++)
        {
            dst[i] = int.Parse(Console.ReadLine().Trim());
        }

        int ans = dst.Max() * 4 + 8;
        for (int i = 0; i < n; i++)
        {
            int cur = dst[i] + dst[(i - 2 + n) % n];
            ans = Math.Min(ans, cur);
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Social running");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}