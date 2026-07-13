// Periodic Strings
namespace CompetitiveProgramming.Kattis.PeriodicStrings;
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
        string s = Console.ReadLine();

        for (int k = 1; k <= s.Length; k++)
        {
            if (s.Length % k != 0)
                continue;

            string a = s.Substring(0, k);
            string b = "";

            while (b.Length < s.Length)
            {
                b += a;
                a = a[a.Length - 1] + a.Substring(0, a.Length - 1);
            }

            if (b == s)
            {
                Console.WriteLine(k);
                break;
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Periodic Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}