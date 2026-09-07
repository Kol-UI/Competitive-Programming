// Game with string
namespace CompetitiveProgramming.CodeForces.Gamewithstring;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        string s = Console.ReadLine();
        if (string.IsNullOrEmpty(s)) return;

        long cnt = 0;
        Stack<char> t = new Stack<char>();

        for (int p = 0; p < s.Length; p++)
        {
            if (t.Count > 0 && t.Peek() == s[p])
            {
                t.Pop();
                cnt++;
            }
            else
            {
                t.Push(s[p]);
            }
        }

        Console.WriteLine(cnt % 2 != 0 ? "Yes" : "No");
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Game with string");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}