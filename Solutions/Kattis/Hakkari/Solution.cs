// Hakkari
namespace CompetitiveProgramming.Kattis.Hakkari;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8601

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        string[] a = new string[n];
        for (int i = 0; i < n; i++)
            a[i] = Console.ReadLine();

        List<(int, int)> ans = new List<(int, int)>();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i][j] == '*')
                    ans.Add((i + 1, j + 1));
            }
        }

        Console.WriteLine(ans.Count);
        foreach (var (x, y) in ans)
            Console.WriteLine($"{x} {y}");
    }
}

#pragma warning restore CS8601
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hakkari");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}