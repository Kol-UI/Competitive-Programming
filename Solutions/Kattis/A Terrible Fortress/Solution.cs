// A Terrible Fortress
namespace CompetitiveProgramming.Kattis.ATerribleFortress;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        int total = 0;
        
        for(int i = 0; i < t; i++)
        {
            total += int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Terrible Fortress");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}