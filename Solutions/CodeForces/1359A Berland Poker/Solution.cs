// Berland Poker
namespace CompetitiveProgramming.CodeForces.BerlandPoker;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0], m = input[1], k = input[2];
            long x = n / k;
            long a = Math.Min(x, m);
            long b = (m - a + k - 2) / (k - 1);
            long res = a - b;
            Console.WriteLine(res);
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
        StyleHelper.Title("Berland Poker");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}