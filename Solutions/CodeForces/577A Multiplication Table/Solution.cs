// Multiplication Table
namespace CompetitiveProgramming.CodeForces.MultiplicationTable;

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
        long n = long.Parse(input[0]);
        long x = long.Parse(input[1]);
        long ans = 0;

        for (long i = 1; i <= n; i++)
        {
            if (x % i == 0 && x <= n * i)
                ans++;
        }

        Console.WriteLine(ans);
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
        StyleHelper.Title("Multiplication Table");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}