// Casimir's String Solitaire

namespace CompetitiveProgramming.CodeForces.CasimirsStringSolitaire;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using System;
using System.Linq;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int tc = 0; tc < t; ++tc)
        {
            string s = Console.ReadLine()!;
            Console.WriteLine(Solve(s) ? "YES" : "NO");
        }
    }

    private static bool Solve(string s)
    {
        return s.Count(ch => ch == 'B') * 2 == s.Length;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Casimir's String Solitaire");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}