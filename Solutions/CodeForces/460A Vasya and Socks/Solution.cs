// Vasya and Socks
namespace CompetitiveProgramming.CodeForces.VasyaandSocks;
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
        int n = input[0], m = input[1];
        int days = 0;
        
        while (n > 0)
        {
            days++;
            n--;
            if (days % m == 0) n++;
        }
        
        Console.WriteLine(days);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vasya and Socks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}