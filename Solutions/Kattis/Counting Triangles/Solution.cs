// Counting Triangles
namespace CompetitiveProgramming.Kattis.CountingTriangles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static bool Intersects(double[] l1, double[] l2)
    {
        double a = l1[0], b = l1[1], c = l1[2], d = l1[3];
        double p = l2[0], q = l2[1], r = l2[2], s = l2[3];

        double det = (c - a) * (s - q) - (r - p) * (d - b);
        if (det == 0)
            return false;

        double lamb = ((s - q) * (r - a) + (p - r) * (s - b)) / det;
        double gamm = ((b - d) * (r - a) + (c - a) * (s - b)) / det;

        return (lamb > 0 && lamb < 1) && (gamm > 0 && gamm < 1);
    }

    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) break;

            double[][] lines = new double[n][];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                lines[i] = new double[4];
                for (int j = 0; j < 4; j++)
                    lines[i][j] = double.Parse(input[j]);
            }

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (Intersects(lines[i], lines[j]) &&
                            Intersects(lines[i], lines[k]) &&
                            Intersects(lines[j], lines[k]))
                        {
                            ans++;
                        }
                    }
                }
            }

            Console.WriteLine(ans);
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
        StyleHelper.Title("Counting Triangles");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}