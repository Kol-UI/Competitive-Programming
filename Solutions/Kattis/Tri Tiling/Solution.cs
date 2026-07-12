// Tri Tiling
namespace CompetitiveProgramming.Kattis.TriTiling;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<(int, int, int), int> dp = new Dictionary<(int, int, int), int>();

    static int F(int a, int b, int c)
    {
        if (a == 0 && b == 0 && c == 0) return 1;
        if (a < 0 || b < 0 || c < 0) return 0;

        if (dp.ContainsKey((a, b, c)))
            return dp[(a, b, c)];

        int ans = 0;

        if (a > b)
        {
            ans = F(a - 2, b, c);
        }
        else if (b > c && b > a)
        {
            ans = F(a, b - 2, c);
        }
        else if (c > b)
        {
            ans = F(a, b, c - 2);
        }
        else
        {
            if (a == b && b == c)
            {
                ans = F(a - 1, b - 1, c) +
                      F(a, b - 1, c - 1) +
                      F(a - 2, b - 2, c - 2);
            }
            else if (a == b)
            {
                ans = F(a - 1, b - 1, c) +
                      F(a - 2, b - 2, c);
            }
            else if (b == c)
            {
                ans = F(a, b - 1, c - 1) +
                      F(a, b - 2, c - 2);
            }
            else
            {
                throw new Exception("Invalid state");
            }
        }

        dp[(a, b, c)] = ans;
        return ans;
    }

    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == -1) break;
            Console.WriteLine(F(n, n, n));
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tri Tiling");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}