// Compositions
namespace CompetitiveProgramming.Kattis.Compositions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        int numTestCases = int.Parse(tLine.Trim());

        while (numTestCases-- > 0)
        {
            string line = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(line)) line = Console.ReadLine();

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int tc = int.Parse(parts[0]);
            int n = int.Parse(parts[1]);
            int m = int.Parse(parts[2]);
            int k = int.Parse(parts[3]);

            long[] dp = new long[n + 1];
            Array.Fill(dp, -1);

            bool Invalid(int x)
            {
                return (x - m) % k == 0;
            }

            long Calculate(int x)
            {
                if (x == 0) return 1;
                if (dp[x] != -1) return dp[x];

                long sum = 0;
                for (int i = 1; i <= x; i++)
                {
                    if (Invalid(i)) continue;
                    sum += Calculate(x - i);
                }

                dp[x] = sum;
                return sum;
            }

            Console.WriteLine($"{tc} {Calculate(n)}");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Compositions");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}