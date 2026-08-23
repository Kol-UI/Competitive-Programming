// Soldier and Badges
namespace CompetitiveProgramming.CodeForces.SoldierandBadges;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] coolness = Array.ConvertAll(Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

        Array.Sort(coolness);

        long cost = 0;
        HashSet<int> factors = new();

        for (int p = 0; p < n; p++)
        {
            int finalVal = coolness[p];
            while (factors.Contains(finalVal))
            {
                finalVal++;
                cost++;
            }
            factors.Add(finalVal);
        }

        Console.WriteLine(cost);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Soldier and Badges");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}