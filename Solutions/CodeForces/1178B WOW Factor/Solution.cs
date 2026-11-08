// WOW Factor
namespace CompetitiveProgramming.CodeForces.WOWFactor;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        string s = Console.ReadLine() + "x";

        long w = 0, wo = 0, h = 0, v = 0, cnt = 0;
        for (long p = 0; p < s.Length; p++)
        {
            if (s[(int)p] == 'v') { v++; }
            else
            {
                if (v > 1)
                {
                    cnt += (v - 1) * wo;
                    w += (v - 1);
                }
                if (s[(int)p] == 'o') { h++; wo += w; }
                v = 0;
            }
        }

        Console.WriteLine(cnt);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("WOW Factor");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}