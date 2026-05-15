// Lost Lineup
namespace CompetitiveProgramming.Kattis.LostLineup;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] ans = new int[n];
        ans[0] = 1;
        
        string[] input = Console.ReadLine().Split();
        for (int i = 2; i <= n; i++)
        {
            int t = int.Parse(input[i - 2]);
            ans[t + 1] = i;
        }
        
        foreach (int i in ans)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lost Lineup");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}