// Mines Motor Company
namespace CompetitiveProgramming.Kattis.MinesMotorCompany;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static (int, int) Mp(string s)
    {
        return (s[0] - 'A', s[1] - 'A');
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var (x, y) = Mp(Console.ReadLine());
        int ans = 0;
        for (int i = 0; i < n - 1; i++)
        {
            var (x1, y1) = Mp(Console.ReadLine());
            ans += Math.Abs(x1 - x) + Math.Abs(y1 - y);
            x = x1;
            y = y1;
        }
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mines Motor Company");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}