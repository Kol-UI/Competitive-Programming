// Equal Shots
namespace CompetitiveProgramming.Kattis.EqualShots;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int a = int.Parse(firstLine[0]);
        int b = int.Parse(firstLine[1]);

        int sa = 0;
        for (int i = 0; i < a; i++)
        {
            string[] input = Console.ReadLine().Split();
            int v = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            sa += v * c;
        }

        int sb = 0;
        for (int i = 0; i < b; i++)
        {
            string[] input = Console.ReadLine().Split();
            int v = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            sb += v * c;
        }

        Console.WriteLine(sa == sb ? "same" : "different");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Equal Shots");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}