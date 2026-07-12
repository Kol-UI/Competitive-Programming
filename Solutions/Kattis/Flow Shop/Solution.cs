// Flow Shop
namespace CompetitiveProgramming.Kattis.FlowShop;
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
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        int[][] a = new int[n][];
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            a[i] = new int[m];
            for (int j = 0; j < m; j++)
                a[i][j] = int.Parse(row[j]);
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i > 0 && j > 0)
                    a[i][j] += Math.Max(a[i - 1][j], a[i][j - 1]);
                else if (i > 0)
                    a[i][j] += a[i - 1][j];
                else if (j > 0)
                    a[i][j] += a[i][j - 1];
            }
        }

        List<string> result = new List<string>();
        for (int i = 0; i < n; i++)
            result.Add(a[i][m - 1].ToString());

        Console.WriteLine(string.Join(" ", result));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Flow Shop");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}