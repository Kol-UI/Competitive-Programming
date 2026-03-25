namespace CompetitiveProgramming.Kattis.ThirteenFloors;

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public static void Main()
    {
        string input = Console.ReadLine()!;

        if (int.TryParse(input, out int n))
        {
            if (n >= 13) n++;
            Console.WriteLine(n);
        }
    }
}
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("13 Floors");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}