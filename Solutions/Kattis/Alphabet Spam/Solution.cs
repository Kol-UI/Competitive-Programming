// Alphabet Spam
namespace CompetitiveProgramming.Kattis.AlphabetSpam;
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
        int n = s.Length;
        int whi = 0;
        int low = 0;
        int upp = 0;
        int sym = 0;

        foreach (char c in s)
        {
            if (c == '_')
                whi++;
            else if (c >= 'a' && c <= 'z')
                low++;
            else if (c >= 'A' && c <= 'Z')
                upp++;
            else
                sym++;
        }

        Console.WriteLine((double)whi / n);
        Console.WriteLine((double)low / n);
        Console.WriteLine((double)upp / n);
        Console.WriteLine((double)sym / n);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alphabet Spam");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}