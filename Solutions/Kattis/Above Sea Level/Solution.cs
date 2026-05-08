// Above Sea Level
namespace CompetitiveProgramming.Kattis.AboveSeaLevel;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604
using System;

class Solution
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        double result = input - 0.3;
        Console.WriteLine(result);
    }
}
#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Above Sea Level");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}