// Distributing Poffins
namespace CompetitiveProgramming.Kattis.DistributingPoffins;
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
        long n = long.Parse(parts[0]);
        long m = long.Parse(parts[1]);

        if (m % n == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Distributing Poffins");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}