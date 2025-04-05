// Luntik and Subsequences
namespace CompetitiveProgramming.CodeForces.LuntikandSubsequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int zero = v.Count(x => x == 0);
            int one = v.Count(x => x == 1);
            Console.WriteLine((1L << zero) * one);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Luntik and Subsequences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}