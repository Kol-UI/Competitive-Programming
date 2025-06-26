// Random Teams
namespace CompetitiveProgramming.CodeForces.RandomTeams;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;

class Program
{
    //static void Main()
    public static void MainSolutution()
    {
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long m = long.Parse(input[1]);

        long div = n / m;
        long rem = n % m;
        long x = m - rem;

        Console.Write($"{x * (div * (div - 1)) / 2 + rem * ((div + 1) * div) / 2} ");
        Console.Write($"{(n - m + 1) * (n - m) / 2}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Random Teams");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
	}
}