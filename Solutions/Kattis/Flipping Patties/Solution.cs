// Flipping Patties
namespace CompetitiveProgramming.Kattis.FlippingPatties;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<(int d, int t)> dt = new List<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int d = int.Parse(input[0]);
            int t = int.Parse(input[1]);
            dt.Add((d, t));
        }

        int mt = 0;
        foreach (var (d, t) in dt)
        {
            if (t > mt) mt = t;
        }

        int[] arr = new int[mt + 1];

        foreach (var (d, t) in dt)
        {
            arr[t] += 1;
            arr[t - d] += 1;
            arr[t - 2 * d] += 1;
        }

        int maxVal = 0;
        foreach (int val in arr)
        {
            if (val > maxVal) maxVal = val;
        }

        Console.WriteLine((maxVal + 1) / 2);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Flipping Patties");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}