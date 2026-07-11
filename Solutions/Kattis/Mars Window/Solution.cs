// Mars Window
namespace CompetitiveProgramming.Kattis.MarsWindow;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int mo = 3;
        int yr = 2018;
        int y = int.Parse(Console.ReadLine());

        while (yr < y)
        {
            yr += 2;
            mo += 2;
            if (mo >= 12)
            {
                mo -= 12;
                yr += 1;
            }
        }

        Console.WriteLine(yr == y ? "yes" : "no");
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mars Window");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}