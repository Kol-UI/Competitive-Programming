// Cheap Travel
namespace CompetitiveProgramming.CodeForces.CheapTravel;
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
    public static void MainSolution()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int a = int.Parse(input[2]);
        int b = int.Parse(input[3]);

        int x = (n / m) * b;
        int y = (int)Math.Ceiling((double)n / m) * b;

        if (b / (double)m < a)
            Console.WriteLine(Math.Min(x + (n % m) * a, y));
        else
            Console.WriteLine(n * a);
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
        StyleHelper.Title("Cheap Travel");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}