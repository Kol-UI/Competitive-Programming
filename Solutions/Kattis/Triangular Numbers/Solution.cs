// Triangular Numbers
namespace CompetitiveProgramming.Kattis.TriangularNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int value = 0;

        for (int i = 1; i <= n; i++)
        {
            value += i;
            Console.WriteLine(value);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Triangular Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}