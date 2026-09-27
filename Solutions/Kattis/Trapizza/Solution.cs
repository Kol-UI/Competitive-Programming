// Trapizza
namespace CompetitiveProgramming.Kattis.Trapizza;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double a1 = Math.PI * Math.Pow(d / 2.0, 2);
        double a2 = h * (a + b) / 2.0;

        Console.WriteLine(a1 > a2 ? "Mahjong!" : a2 > a1 ? "Trapizza!" : "Jafn storar!");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Trapizza");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}