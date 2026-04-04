// 3-palindrome
namespace CompetitiveProgramming.CodeForces.Threepalindrome;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        for (long p = 0; p < n; p++)
        {
            char c = (char)('a' + (((p % 4) + 1) % 4 > 1 ? 1 : 0));
            Console.Write(c);
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("3-palindrome");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}