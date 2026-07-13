// EpigDanceOff
namespace CompetitiveProgramming.Kattis.EpigDanceOff;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        string[] a = new string[n];
        for (int i = 0; i < n; i++)
            a[i] = Console.ReadLine() + "_";

        int ans = 0;
        for (int i = 0; i <= m; i++)
        {
            bool allUnderscore = true;
            for (int j = 0; j < n; j++)
            {
                if (a[j][i] != '_')
                {
                    allUnderscore = false;
                    break;
                }
            }
            if (allUnderscore)
                ans++;
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("EpigDanceOff");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}