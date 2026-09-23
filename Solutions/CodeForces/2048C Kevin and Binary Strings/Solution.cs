// Kevin and Binary Strings
namespace CompetitiveProgramming.CodeForces.KevinandBinaryStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s)) s = Console.ReadLine();

            int a = 0, z = 0;
            bool fz = false;
            int n = s.Length;

            for (int p = 0; p < n; p++)
            {
                if (s[p] == '0')
                {
                    ++z;
                    fz = true;
                }
                else if (fz)
                {
                    break;
                }
                else
                {
                    ++a;
                }
            }

            int shift = a < z ? a : z;
            int start = a + 1 - shift;
            start = start < n ? start : n;
            int stop = n - shift;

            Console.WriteLine($"1 {n} {start} {stop}");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kevin and Binary Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}