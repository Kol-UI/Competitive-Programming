// Email from Polycarp
namespace CompetitiveProgramming.CodeForces.EmailfromPolycarp;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        while (n-- > 0)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            bool possible = true;
            long idx = 0;
            for (long p = 0; p < t.Length; p++)
            {
                if (idx < s.Length && s[(int)idx] == t[(int)p]) { idx++; }
                else if (p > 0 && t[(int)p] == t[(int)(p - 1)]) { }
                else { possible = false; break; }
            }
            if (idx < s.Length) { possible = false; }
            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Email from Polycarp");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}