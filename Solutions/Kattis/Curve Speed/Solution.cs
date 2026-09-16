// Curve Speed
namespace CompetitiveProgramming.Kattis.CurveSpeed;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double r = double.Parse(parts[0]);
            double s = double.Parse(parts[1]);

            double v = Math.Sqrt(r * (s + 0.16) / 0.067);
            Console.WriteLine(Math.Round(v));
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Curve Speed");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}