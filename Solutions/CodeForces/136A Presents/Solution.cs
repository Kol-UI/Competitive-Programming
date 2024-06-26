// Presents

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Presents;

class Program
{
    //static void Main()
    static void Solution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] values = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            result[values[i] - 1] = i + 1;
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Presents");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}