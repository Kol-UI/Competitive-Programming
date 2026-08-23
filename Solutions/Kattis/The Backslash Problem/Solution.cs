// The Backslash Problem
namespace CompetitiveProgramming.Kattis.TheBackslashProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static bool IsSpecial(char c)
    {
        return (c >= '!' && c <= '*') || (c >= '[' && c <= ']');
    }

    static List<char> Escapi(List<char> s)
    {
        List<char> newS = new List<char>();
        foreach (char c in s)
        {
            if (IsSpecial(c))
                newS.Add('\\');
            newS.Add(c);
        }
        return newS;
    }

    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            string input = Console.ReadLine();
            List<char> s = new List<char>(input);

            for (int i = 0; i < n; i++)
            {
                s = Escapi(s);
            }

            Console.WriteLine(new string(s.ToArray()));
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
        StyleHelper.Title("The Backslash Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}