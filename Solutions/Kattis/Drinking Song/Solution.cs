// Drinking Song
namespace CompetitiveProgramming.Kattis.DrinkingSong;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;

class Program
{
    static void PrintStrs(int i, string s)
    {
        if (i == 1)
        {
            Console.WriteLine($"1 bottle of {s} on the wall, 1 bottle of {s}.");
            Console.WriteLine($"Take it down, pass it around, no more bottles of {s}.");
        }
        else if (i == 2)
        {
            Console.WriteLine($"2 bottles of {s} on the wall, 2 bottles of {s}.");
            Console.WriteLine($"Take one down, pass it around, 1 bottle of {s} on the wall.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"{i} bottles of {s} on the wall, {i} bottles of {s}.");
            Console.WriteLine($"Take one down, pass it around, {i - 1} bottles of {s} on the wall.");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        for (int i = n; i > 0; i--)
        {
            PrintStrs(i, s);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Drinking Song");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}