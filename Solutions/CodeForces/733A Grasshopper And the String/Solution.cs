// Grasshopper And the String
namespace CompetitiveProgramming.CodeForces.GrasshopperAndtheString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static bool IsVowel(char c)
    {
        return c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'Y';
    }

    static void Main()
    {
        string s = Console.ReadLine();
        int prev = -1;
        int diff = 0;
        int maxDiff = 0;
        
        for (int p = 0; p < s.Length; p++)
        {
            if (IsVowel(s[p]))
            {
                diff = p - prev;
                if (diff > maxDiff) maxDiff = diff;
                prev = p;
            }
        }
        
        diff = s.Length - prev;
        if (diff > maxDiff) maxDiff = diff;
        
        Console.WriteLine(maxDiff);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Grasshopper And the String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}