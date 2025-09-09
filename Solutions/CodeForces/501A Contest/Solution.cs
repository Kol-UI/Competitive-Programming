// Contest
namespace CompetitiveProgramming.CodeForces.Contest;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        int d = int.Parse(input[3]);
        
        int mishaScore = 3 * a / 10;
        if (a - a * c / 250 > mishaScore) mishaScore = a - a * c / 250;
        
        int vasyaScore = 3 * b / 10;
        if (b - b * d / 250 > vasyaScore) vasyaScore = b - b * d / 250;
        
        if (mishaScore < vasyaScore) Console.WriteLine("Vasya");
        else if (mishaScore > vasyaScore) Console.WriteLine("Misha");
        else Console.WriteLine("Tie");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Contest");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}