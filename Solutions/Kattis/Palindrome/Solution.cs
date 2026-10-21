// Palindrome
namespace CompetitiveProgramming.Kattis.Palindrome;
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
        string s = Console.ReadLine();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        Console.WriteLine(s == reversed ? "Palindrome!" : "Nothing special about this string :(");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Palindrome");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}