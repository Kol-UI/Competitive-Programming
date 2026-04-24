// Shohag Loves Strings
namespace CompetitiveProgramming.CodeForces.ShohagLovesStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            string ans = "-1";
            
            for (long p = 1; p < s.Length; p++)
            {
                if (s[(int)(p - 1)] == s[(int)p])
                {
                    ans = s.Substring((int)(p - 1), 2);
                    break;
                }
                else if (p > 1 && s[(int)(p - 2)] != s[(int)(p - 1)] && s[(int)(p - 2)] != s[(int)p] && s[(int)(p - 1)] != s[(int)p])
                {
                    ans = s.Substring((int)(p - 2), 3);
                    break;
                }
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Shohag Loves Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}