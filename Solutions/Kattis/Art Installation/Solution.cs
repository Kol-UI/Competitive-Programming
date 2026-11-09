// Art Installation
namespace CompetitiveProgramming.Kattis.ArtInstallation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        int[] need = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] have = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        for (int i = 0; i < 3; i++)
            need[i] = Math.Max(0, need[i] - have[i]);

        string[] cVals = Console.ReadLine().Split();
        int c01 = int.Parse(cVals[0]);
        int c12 = int.Parse(cVals[1]);

        int ans = 0;

        int buy0 = Math.Min(c01, need[0]);
        ans += buy0;
        need[0] -= buy0;
        c01 -= buy0;

        int buy1 = Math.Min(c12, need[2]);
        ans += buy1;
        need[2] -= buy1;
        c12 -= buy1;

        int buy01 = Math.Min(c01 + c12, need[1]);
        ans += buy01;
        need[1] -= buy01;

        if (Math.Max(need[0], Math.Max(need[1], need[2])) == 0)
            Console.WriteLine(ans);
        else
            Console.WriteLine(-1);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Art Installation");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}