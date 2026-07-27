// Comparing Strings
namespace CompetitiveProgramming.CodeForces.ComparingStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        bool same = true;

        if (first.Length != second.Length)
        {
            same = false;
        }
        else
        {
            long diffA = -1;
            long diffB = -1;

            for (int k = 0; k < first.Length; k++)
            {
                if (first[k] == second[k]) continue;

                if (diffA < 0)
                    diffA = k;
                else if (diffB < 0)
                    diffB = k;
                else
                {
                    same = false;
                    break;
                }
            }

            if (diffA >= 0 && diffB < 0)
                same = false;

            if (diffA >= 0 && diffB >= 0 &&
                (first[(int)diffA] != second[(int)diffB] ||
                 first[(int)diffB] != second[(int)diffA]))
            {
                same = false;
            }
        }

        Console.WriteLine(same ? "YES" : "NO");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Comparing Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}