// QWERTY
namespace CompetitiveProgramming.Kattis.QWERTY;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string s = "qwertyuiopasdfghjklzxcvbnm";

        Console.ReadLine();
        string input = Console.ReadLine();

        if (input != null)
        {
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    Console.Write(c);
                }
                else
                {
                    Console.Write(s[c - 'a']);
                }
            }
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("QWERTY");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}