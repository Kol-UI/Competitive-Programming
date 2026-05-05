// Boss Battle
namespace CompetitiveProgramming.Kattis.BossBattle;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604


using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n -= 2;
        n = Math.Max(n, 1);
        Console.WriteLine(n);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Boss Battle");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}