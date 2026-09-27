// Tram
namespace CompetitiveProgramming.Kattis.Tram;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        int n = int.Parse(nLine.Trim());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(line)) line = Console.ReadLine();

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[1]);

            sum += (y - x);
        }

        Console.WriteLine(sum / n);
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tram");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}