// Above Average
namespace CompetitiveProgramming.Kattis.AboveAverage;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a = input.Skip(1).ToArray();
            double sm = a.Sum();
            int n = a.Length;
            int cnt = a.Count(x => x * n > sm);
            double perc = (double)cnt / n * 100;
            Console.WriteLine($"{perc:F3}%");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Above Average");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}