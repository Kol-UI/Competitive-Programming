// Smoothie Stand
namespace CompetitiveProgramming.Kattis.SmoothieStand;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] kr = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int k = int.Parse(kr[0]);
        int r = int.Parse(kr[1]);

        int[] cap = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

        int ans = 0;
        for (int i = 0; i < r; i++)
        {
            int[] line = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            int cost = line[^1];
            int[] a = line.Take(line.Length - 1).ToArray();

            int can = int.MaxValue;
            for (int j = 0; j < k; j++)
            {
                if (a[j] != 0)
                {
                    can = Math.Min(can, cap[j] / a[j]);
                }
            }

            ans = Math.Max(ans, can * cost);
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smoothie Stand");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}