// Judging Moose
namespace CompetitiveProgramming.Kattis.JudgingMoose;
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
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        
        if (a == 0 && b == 0)
        {
            Console.WriteLine("Not a moose");
            return;
        }
        
        if (a == b)
        {
            Console.Write("Even ");
        }
        else
        {
            Console.Write("Odd ");
        }
        
        Console.WriteLine(2 * Math.Max(a, b));
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Judging Moose");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}