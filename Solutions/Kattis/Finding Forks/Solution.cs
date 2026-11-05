// Finding Forks
namespace CompetitiveProgramming.Kattis.FindingForks;
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
        int[] a = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
        Console.WriteLine(a[0] + a[1]);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Finding Forks");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}