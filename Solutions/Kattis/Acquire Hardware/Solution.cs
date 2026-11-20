// Acquire Hardware
namespace CompetitiveProgramming.Kattis.AcquireHardware;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void TestCase()
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);

        long[,] dp = new long[n, m];

        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();

            for (int j = 0; j < m; j++)
            {
                long c = 0;
                if (j > 0) c = dp[i, j - 1];
                if (i > 0) c = Math.Max(c, dp[i - 1, j]);

                if (s[j] == 'I') c++;

                dp[i, j] = c;
            }
        }

        Console.WriteLine(dp[n - 1, m - 1]);
    }

    static void Main()
    {
        int t = 1;
        for (int tc = 1; tc <= t; tc++)
        {
            TestCase();
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Acquire Hardware");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}