// Prozor
namespace CompetitiveProgramming.Kattis.Prozor;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void PrintWhack(List<string> v, int i, int j, int side)
    {
        char[] row = v[i].ToCharArray();
        for (int k = 0; k < side; k++)
        {
            v[i] = v[i].Remove(j + k, 1).Insert(j + k, "-");
            v[i + side - 1] = v[i + side - 1].Remove(j + k, 1).Insert(j + k, "-");
            v[i + k] = v[i + k].Remove(j, 1).Insert(j, "|");
            v[i + k] = v[i + k].Remove(j + side - 1, 1).Insert(j + side - 1, "|");
        }

        v[i] = v[i].Remove(j, 1).Insert(j, "+");
        v[i + side - 1] = v[i + side - 1].Remove(j, 1).Insert(j, "+");
        v[i] = v[i].Remove(j + side - 1, 1).Insert(j + side - 1, "+");
        v[i + side - 1] = v[i + side - 1].Remove(j + side - 1, 1).Insert(j + side - 1, "+");
    }

    static int Whack(List<string> v, int i, int j, int side)
    {
        int total = 0;
        for (int k = 1; k < side - 1; k++)
        {
            for (int l = 1; l < side - 1; l++)
            {
                if (v[i + k][j + l] == '*')
                    total++;
            }
        }
        return total;
    }

    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int h = int.Parse(firstLine[0]);
        int w = int.Parse(firstLine[1]);
        int side = int.Parse(firstLine[2]);

        List<string> v = new List<string>();
        for (int i = 0; i < h; i++)
        {
            v.Add(Console.ReadLine());
        }

        int m = -1;
        int max_i = -1;
        int max_j = -1;

        for (int i = 0; i < h - side + 1; i++)
        {
            for (int j = 0; j < w - side + 1; j++)
            {
                int thisWhack = Whack(v, i, j, side);
                if (thisWhack > m)
                {
                    m = thisWhack;
                    max_i = i;
                    max_j = j;
                }
            }
        }

        PrintWhack(v, max_i, max_j, side);

        Console.WriteLine(m);
        foreach (string row in v)
        {
            Console.WriteLine(row);
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
        StyleHelper.Title("Prozor");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}