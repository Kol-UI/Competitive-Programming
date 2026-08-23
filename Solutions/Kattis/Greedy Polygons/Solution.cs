// Greedy Polygons
namespace CompetitiveProgramming.Kattis.GreedyPolygons;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int l = int.Parse(input[1]);
            int d = int.Parse(input[2]);
            int g = int.Parse(input[3]);

            double p = l * n;
            double a = l / (2 * Math.Tan(Math.PI / n));
            double A = a * p / 2;

            double ans = Math.PI * d * g * d * g + A + n * d * g * l;
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
        StyleHelper.Title("Greedy Polygons");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}