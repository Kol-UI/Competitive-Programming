// Memories of Passport Control
namespace CompetitiveProgramming.Kattis.MemoriesofPassportControl;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int k = int.Parse(input[0]);
        int s = int.Parse(input[1]);

        int x = 0;
        while (s - k * (x + 1) >= 0)
        {
            x++;
        }

        Console.WriteLine(x + s - k * x);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Memories of Passport Control");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}