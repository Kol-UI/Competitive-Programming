// Welcome Sign
namespace CompetitiveProgramming.Kattis.WelcomeSign;
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
        if (string.IsNullOrWhiteSpace(input)) return;

        string[] rc = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(rc[0]);
        int c = int.Parse(rc[1]);

        bool fl = false;
        for (int i = 0; i < rows; i++)
        {
            string s = Console.ReadLine();
            int pad = c - s.Length;
            int l = pad / 2;
            int r = l;

            if (l + r != pad)
            {
                if (fl)
                {
                    l++;
                }
                else
                {
                    r++;
                }
                fl = !fl;
            }

            Console.WriteLine($"{new string('.', l)}{s}{new string('.', r)}");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Welcome Sign");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}