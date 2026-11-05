// Certainly
namespace CompetitiveProgramming.Kattis.Certainly;
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
        int pos = 0;
        int ans = 0;

        while (true)
        {
            pos = s.IndexOf("certainly", pos);
            if (pos == -1) break;
            ans++;
            pos += 7;
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Certainly");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}