// Bijele
namespace CompetitiveProgramming.Kattis.Bijele;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int king = int.Parse(input[0]);
        int queens = int.Parse(input[1]);
        int rooks = int.Parse(input[2]);
        int bishops = int.Parse(input[3]);
        int knights = int.Parse(input[4]);
        int pawns = int.Parse(input[5]);

        Console.WriteLine($"{1 - king} {1 - queens} {2 - rooks} {2 - bishops} {2 - knights} {8 - pawns}");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bijele");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}