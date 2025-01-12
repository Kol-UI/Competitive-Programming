// Colorful Stones (Simplified Edition)

namespace CompetitiveProgramming.CodeForces.ColorfulStonesSimplifiedEdition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        string s = ReadLn();
        string t = ReadLn();
        Console.WriteLine(Solve(s, t));
    }

    private static int Solve(string s, string t)
    {
        int index = 0;
        foreach (char instruction in t)
        {
            if (s[index] == instruction)
            {
                index++;
            }
        }
        return index + 1;
    }

    private static string ReadLn() => Console.ReadLine()!;
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Colorful Stones (Simplified Edition)");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}