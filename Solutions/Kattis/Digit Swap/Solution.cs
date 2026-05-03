// Digit Swap
namespace CompetitiveProgramming.Kattis.DigitSwap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(new string(arr));
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Digit Swap");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}