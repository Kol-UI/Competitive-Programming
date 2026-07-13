// Red Rover
namespace CompetitiveProgramming.Kattis.RedRover;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int best = s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                string temp = s.Substring(i, j - i);
                string replaced = s.Replace(temp, "M");
                int length = replaced.Length + temp.Length;
                if (length < best)
                    best = length;
            }
        }

        Console.WriteLine(best);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Red Rover");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}