// ASCII kassi
namespace CompetitiveProgramming.Kattis.ASCIIkassi;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604
using System;

public class Solution
{
    static public void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("+" + new string('-', n) + "+");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|" + new string(' ', n) + "|");
        }

        Console.WriteLine("+" + new string('-', n) + "+");
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("ASCII kassi");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}