// Counting Stars
namespace CompetitiveProgramming.Kattis.CountingStars;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    struct Pixel
    {
        public char c;
        public bool used;
    }

    static int Floodfill(int m, int n, int i, int j, Pixel[][] v)
    {
        if (i < 0 || i >= m || j < 0 || j >= n) return 0;
        if (v[i][j].used) return 0;

        v[i][j].used = true;

        Floodfill(m, n, i, j + 1, v);
        Floodfill(m, n, i, j - 1, v);
        Floodfill(m, n, i + 1, j, v);
        Floodfill(m, n, i - 1, j, v);

        return 1;
    }

    static void Main()
    {
        int count = 1;
        string line;

        while ((line = Console.ReadLine()) != null)
        {
            string[] firstLine = line.Split();
            if (firstLine.Length < 2) break;

            int m = int.Parse(firstLine[0]);
            int n = int.Parse(firstLine[1]);

            Pixel[][] v = new Pixel[m][];

            for (int i = 0; i < m; i++)
            {
                string row = Console.ReadLine();
                v[i] = new Pixel[n];
                for (int j = 0; j < n; j++)
                {
                    v[i][j].c = row[j];
                    v[i][j].used = (row[j] == '#');
                }
            }

            int stars = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    stars += Floodfill(m, n, i, j, v);
                }
            }

            Console.WriteLine($"Case {count}: {stars}");
            count++;
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Counting Stars");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}