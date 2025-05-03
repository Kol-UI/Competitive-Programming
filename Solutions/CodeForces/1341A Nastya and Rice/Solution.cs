// Nastya and Rice
namespace CompetitiveProgramming.CodeForces.NastyaandRice;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int n = input[0], a = input[1], b = input[2], c = input[3], d = input[4];
            Console.WriteLine(n * (a - b) > c + d || n * (a + b) < c - d ? "No" : "Yes");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Nastya and Rice");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}