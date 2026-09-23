// Snowfall
namespace CompetitiveProgramming.Kattis.Snowfall;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        int n = int.Parse(nLine.Trim());
        long c = 0;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(line)) line = Console.ReadLine();

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int t = int.Parse(parts[0]);
            long a = long.Parse(parts[1]);

            if (t == 0)
            {
                c += a;
            }
            else
            {
                c -= Math.Min(c, a);
            }
        }

        Console.WriteLine(c);
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Snowfall");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}