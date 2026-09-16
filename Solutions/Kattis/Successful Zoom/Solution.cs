// Successful Zoom
namespace CompetitiveProgramming.Kattis.SuccessfulZoom;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        int n = int.Parse(nLine.Trim());
        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(parts[i]);
        }

        for (int k = 1; k <= n / 2; ++k)
        {
            int prv = -1;
            for (int q = 1; q * k - 1 < n; ++q)
            {
                if (a[q * k - 1] > prv)
                {
                    prv = a[q * k - 1];
                }
                else
                {
                    prv = -69;
                    break;
                }
            }

            if (prv != -69)
            {
                Console.WriteLine(k);
                return;
            }
        }

        Console.WriteLine("ABORT!");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Successful Zoom");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}