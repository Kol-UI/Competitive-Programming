// Carrot Cakes
namespace CompetitiveProgramming.CodeForces.CarrotCakes;
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
        int n = input[0];
        int t = input[1];
        int k = input[2];
        int d = input[3];
        
        Console.WriteLine(d < (n - 1) / k * t ? "YES" : "NO");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Carrot Cakes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}