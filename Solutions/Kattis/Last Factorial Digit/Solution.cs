// Last Factorial Digit
namespace CompetitiveProgramming.Kattis.LastFactorialDigit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        
        int ans = 1;
        for (int i = 1; i <= n; i++)
        {
            ans *= i;
            ans %= 10;
        }
        
        Console.WriteLine(ans);
    }
    
    static void Main()
    {
        int cases = int.Parse(Console.ReadLine());
        while (cases-- > 0)
        {
            Solve();
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Last Factorial Digit");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}