// Cyanide Rivers
namespace CompetitiveProgramming.Kattis.CyanideRivers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        string input = Console.ReadLine();
        int result = (input.Split('1').Select(s => s.Length).Max() + 1) >> 1;
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cyanide Rivers");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}