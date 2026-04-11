// Spavanac
namespace CompetitiveProgramming.Kattis.Spavanac;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int h = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        
        int t = h * 60 + m;
        t -= 45;
        
        if (t < 0)
        {
            t += 24 * 60;
        }
        
        h = t / 60;
        m = t % 60;
        
        Console.WriteLine($"{h} {m}");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Spavanac");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}