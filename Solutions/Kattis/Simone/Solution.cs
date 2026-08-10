// Simone
namespace CompetitiveProgramming.Kattis.Simone;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);

        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] cnt = new int[k + 1];
        foreach (int x in a)
            cnt[x]++;

        int mn = cnt[1];
        List<int> minis = new List<int>();

        for (int i = 1; i <= k; i++)
        {
            if (cnt[i] < mn)
            {
                mn = cnt[i];
                minis.Clear();
                minis.Add(i);
            }
            else if (cnt[i] == mn)
            {
                minis.Add(i);
            }
        }

        minis.Sort();

        Console.WriteLine(minis.Count);
        Console.WriteLine(string.Join(" ", minis));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Simone");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}