// New Year Candles
namespace CompetitiveProgramming.CodeForces.NewYearCandles;
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
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int temp = 0;
        int hour = 0;
        
        for (int i = 0; i < a; i++)
        {
            hour++;
            temp++;
            if (temp == b)
            {
                a++;
                temp = 0;
            }
        }
        
        Console.WriteLine(hour);
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
        StyleHelper.Title("New Year Candles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}