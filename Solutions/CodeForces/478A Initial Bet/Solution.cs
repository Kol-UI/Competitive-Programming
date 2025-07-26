// Initial Bet
namespace CompetitiveProgramming.CodeForces.InitialBet;
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
        const int n = 5;
        int sum = 0;
        int[] temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int p = 0; p < n; p++) sum += temp[p];

        Console.WriteLine(sum > 0 && sum % n == 0 ? sum / n : -1);
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
        StyleHelper.Title("Initial Bet");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}