// Board Moves
namespace CompetitiveProgramming.CodeForces.BoardMoves;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long s = 0;
            while (n > 0)
            {
                long k = (n * 2) + (n - 2) * 2;
                k = k * (n / 2);
                n -= 2;
                s += k;
            }
            Console.WriteLine(s);
        }
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
        StyleHelper.Title("Board Moves");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}