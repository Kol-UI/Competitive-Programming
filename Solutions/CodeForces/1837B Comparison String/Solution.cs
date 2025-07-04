// Comparison String
namespace CompetitiveProgramming.CodeForces.ComparisonString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            string s = Console.ReadLine()!;
            int maxLen = 1;
            int currentLen = 1;

            for (int i = 1; i < n; i++)
            {
                if (s[i] == s[i - 1])
                {
                    currentLen++;
                    maxLen = Math.Max(maxLen, currentLen);
                }
                else
                {
                    currentLen = 1;
                }
            }

            Console.WriteLine(maxLen + 1);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Comparison String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}