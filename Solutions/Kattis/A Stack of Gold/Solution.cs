// A Stack of Gold
namespace CompetitiveProgramming.Kattis.AStackofGold;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int w = input[0];
        int s = input[1];
        
        long c = (long)s * (s + 1) / 2;
        long wt = c * 29260;
        long dif = w - wt;
        long result = dif / (29370 - 29260);
        
        Console.WriteLine(result);
    }
}
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Stack of Gold");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}