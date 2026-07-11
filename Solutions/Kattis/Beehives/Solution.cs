// Beehives
namespace CompetitiveProgramming.Kattis.Beehives;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static double Dist(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }

    static void Main()
    {
        while (true)
        {
            string[] firstLine = Console.ReadLine().Split();
            double d = double.Parse(firstLine[0]);
            int n = int.Parse(firstLine[1]);

            if (n + d == 0) break;

            List<(double, double)> pos = new List<(double, double)>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                pos.Add((x, y));
            }

            int sour = 0;
            int sweet = 0;

            for (int i = 0; i < n; i++)
            {
                bool hasSour = false;
                for (int j = 0; j < n; j++)
                {
                    if (i == j) continue;
                    if (Dist(pos[i].Item1, pos[i].Item2, pos[j].Item1, pos[j].Item2) <= d)
                    {
                        hasSour = true;
                        break;
                    }
                }
                if (hasSour)
                    sour++;
                else
                    sweet++;
            }

            Console.WriteLine($"{sour} sour, {sweet} sweet");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Beehives");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}