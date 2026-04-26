// Autori
namespace CompetitiveProgramming.Kattis.Autori;
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
        string s = Console.ReadLine();
        string t = s[0].ToString();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '-')
            {
                t += s[i + 1];
            }
        }
        
        Console.WriteLine(t);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Autori");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}