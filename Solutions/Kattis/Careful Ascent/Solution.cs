// Careful Ascent
namespace CompetitiveProgramming.Kattis.CarefulAscent;
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
        double x = double.Parse(firstLine[0]);
        double y = double.Parse(firstLine[1]);
        int n = int.Parse(Console.ReadLine());

        List<(double l, double u, double f)> shield = new List<(double, double, double)>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            double l = double.Parse(input[0]);
            double u = double.Parse(input[1]);
            double f = double.Parse(input[2]);
            shield.Add((l, u, f));
        }

        shield.Sort((a, b) => a.l.CompareTo(b.l));

        double sm = 0.0;
        double prv = 0.0;

        foreach (var (l, u, f) in shield)
        {
            sm += l - prv;
            sm += f * (u - l);
            prv = u;
        }

        sm += y - prv;

        Console.WriteLine(x / sm);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Careful Ascent");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}