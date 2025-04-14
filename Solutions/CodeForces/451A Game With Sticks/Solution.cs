// Game With Sticks
namespace CompetitiveProgramming.CodeForces.GameWithSticks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int n = Math.Min(input[0], input[1]);
        Console.WriteLine(n % 2 == 0 ? "Malvika" : "Akshat");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Game With Sticks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}