// Airfare Grants
namespace CompetitiveProgramming.Kattis.AirfareGrants;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        
        int result = Math.Max(0, a.Min() - a.Max() / 2);
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Airfare Grants");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}