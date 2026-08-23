// Unlock Pattern
namespace CompetitiveProgramming.Kattis.UnlockPattern;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static (int, int) Find(int[][] v, int key)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (v[i][j] == key)
                    return (i, j);
            }
        }
        return (0, 0);
    }

    static double Distance((int, int) a, (int, int) b)
    {
        double d = Math.Pow(a.Item1 - b.Item1, 2) + Math.Pow(a.Item2 - b.Item2, 2);
        return Math.Sqrt(d);
    }

    static void Main()
    {
        int[][] v = new int[3][];
        for (int i = 0; i < 3; i++)
        {
            v[i] = new int[3];
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < 3; j++)
                v[i][j] = int.Parse(input[j]);
        }

        double dist = 0;
        for (int i = 1; i <= 8; i++)
        {
            dist += Distance(Find(v, i), Find(v, i + 1));
        }

        Console.WriteLine($"{dist:F10}");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unlock Pattern");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}