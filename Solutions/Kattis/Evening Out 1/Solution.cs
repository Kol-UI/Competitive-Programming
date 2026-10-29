// Evening Out 1
namespace CompetitiveProgramming.Kattis.EveningOutOne;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) return;

        string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        long a = long.Parse(parts[0]);
        long b = long.Parse(parts[1]);

        long k = a / b;

        long x = k * b;
        long y = (k + 1) * b;

        Console.WriteLine(Math.Min(y - a, a - x));
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Evening Out 1");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}