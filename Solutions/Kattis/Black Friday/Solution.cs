// Black Friday
namespace CompetitiveProgramming.Kattis.BlackFriday;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Dictionary<int, int> cnt = new Dictionary<int, int>();
        foreach (int x in a)
        {
            if (!cnt.ContainsKey(x))
                cnt[x] = 0;
            cnt[x]++;
        }
        
        int ans = 0;
        foreach (var kvp in cnt)
        {
            if (kvp.Value == 1 && kvp.Key > ans)
                ans = kvp.Key;
        }
        
        if (ans == 0)
            Console.WriteLine("none");
        else
            Console.WriteLine(Array.IndexOf(a, ans) + 1);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Black Friday");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}