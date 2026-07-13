// Mumble Rap
namespace CompetitiveProgramming.Kattis.MumbleRap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        string s = Console.ReadLine();

        string[] numbers = Regex.Split(s, @"[^\d]+");
        int max = numbers.Where(x => !string.IsNullOrEmpty(x))
                         .Select(int.Parse)
                         .Max();

        Console.WriteLine(max);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mumble Rap");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}