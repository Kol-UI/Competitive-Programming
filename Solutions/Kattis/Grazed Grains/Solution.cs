// Grazed Grains
namespace CompetitiveProgramming.Kattis.GrazedGrains;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Globalization;

class Program
{
    static void TestCase()
    {
        string input = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(input)) return;

        int n = int.Parse(input);

        (double cx, double cy, double r)[] circ = new (double, double, double)[n];
        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double cx = double.Parse(parts[0], CultureInfo.InvariantCulture);
            double cy = double.Parse(parts[1], CultureInfo.InvariantCulture);
            double r = double.Parse(parts[2], CultureInfo.InvariantCulture);
            circ[i] = (cx, cy, r);
        }

        int NUM_SAMPLE = 1000000;
        Random rng = new Random();

        int num_inside = 0;
        for (int i = 0; i < NUM_SAMPLE; ++i)
        {
            double x = rng.NextDouble() * 30.0 - 10.0;
            double y = rng.NextDouble() * 30.0 - 10.0;

            foreach (var (cx, cy, r) in circ)
            {
                if ((cx - x) * (cx - x) + (cy - y) * (cy - y) <= r * r)
                {
                    ++num_inside;
                    break;
                }
            }
        }

        Console.WriteLine(30 * 30 * ((double)num_inside) / ((double)(NUM_SAMPLE)));
    }

    static void Main()
    {
        int t = 1;

        for (int tc = 1; tc <= t; ++tc)
        {
            TestCase();
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Grazed Grains");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}