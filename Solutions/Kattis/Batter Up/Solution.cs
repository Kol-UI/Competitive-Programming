// Batter Up
namespace CompetitiveProgramming.Kattis.BatterUp;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        Console.ReadLine();
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        var filtered = a.Where(x => x >= 0).ToArray();
        double average = (double)filtered.Sum() / filtered.Length;
        
        Console.WriteLine($"{average:F9}");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Batter Up");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}