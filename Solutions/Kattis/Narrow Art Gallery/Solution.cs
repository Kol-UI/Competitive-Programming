// Narrow Art Gallery
namespace CompetitiveProgramming.Kattis.NarrowArtGallery;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    const int mxN = 205;
    static long[,] val = new long[mxN, 2];
    static long[, ,] dp = new long[mxN, mxN, 3];

    static void TestCase()
    {
        string[] firstLine = Console.ReadLine().Split();
        long n = long.Parse(firstLine[0]);
        long k = long.Parse(firstLine[1]);
        
        if (n + k == 0) Environment.Exit(0);

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            val[i, 0] = long.Parse(input[0]);
            val[i, 1] = long.Parse(input[1]);
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                dp[i, j, 0] = long.MinValue;
                dp[i, j, 1] = long.MinValue;
                dp[i, j, 2] = long.MinValue;
            }
        }

        dp[0, 0, 0] = val[0, 0] + val[0, 1];
        if (k >= 1)
        {
            dp[0, 1, 1] = val[0, 1];
            dp[0, 1, 2] = val[0, 0];
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j <= i + 1; j++)
            {
                dp[i, j, 0] = Math.Max(dp[i - 1, j, 0], Math.Max(dp[i - 1, j, 1], dp[i - 1, j, 2]));
                if (dp[i, j, 0] > long.MinValue) dp[i, j, 0] += val[i, 0] + val[i, 1];

                if (j > 0)
                {
                    dp[i, j, 1] = Math.Max(dp[i - 1, j - 1, 1], dp[i - 1, j - 1, 0]);
                    if (dp[i, j, 1] > long.MinValue) dp[i, j, 1] += val[i, 1];
                    
                    dp[i, j, 2] = Math.Max(dp[i - 1, j - 1, 2], dp[i - 1, j - 1, 0]);
                    if (dp[i, j, 2] > long.MinValue) dp[i, j, 2] += val[i, 0];
                }
            }
        }

        long ans = Math.Max(dp[n - 1, k, 0], Math.Max(dp[n - 1, k, 1], dp[n - 1, k, 2]));
        Console.WriteLine(ans);
    }

    static void Main()
    {
        while (true) TestCase();
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Narrow Art Gallery");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}