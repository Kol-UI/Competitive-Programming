// Colour Wars
namespace CompetitiveProgramming.Kattis.ColourWars;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        Dictionary<int, int> cnt = new Dictionary<int, int>();
        Console.ReadLine();
        string[] vals = Console.ReadLine().Split();
        foreach (string val in vals)
        {
            int x = int.Parse(val);
            if (cnt.ContainsKey(x)) cnt[x]++;
            else cnt[x] = 1;
        }

        int ans = 0;
        foreach (var kv in cnt)
        {
            int sz = kv.Key + 1;
            ans += (kv.Value + sz - 1) / sz * sz;
        }
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Colour Wars");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}