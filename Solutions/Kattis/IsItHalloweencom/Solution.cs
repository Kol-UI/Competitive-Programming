// IsItHalloween.com
namespace CompetitiveProgramming.Kattis.IsItHalloweencom;
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
        string s1 = input[0];
        string s2 = input[1];
        
        if ((s1 == "OCT" && s2 == "31") || (s1 == "DEC" && s2 == "25"))
        {
            Console.WriteLine("yup");
        }
        else
        {
            Console.WriteLine("nope");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("IsItHalloween.com");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}