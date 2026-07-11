// Simplicity
namespace CompetitiveProgramming.Kattis.Simplicity;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        Dictionary<char, int> cnt = new Dictionary<char, int>();
        
        foreach (char c in s)
        {
            if (!cnt.ContainsKey(c))
                cnt[c] = 0;
            cnt[c]++;
        }
        
        List<int> vals = cnt.Values.ToList();
        vals.Sort((a, b) => b.CompareTo(a));
        
        int sum = vals.Sum();
        int firstTwo = 0;
        if (vals.Count >= 2)
            firstTwo = vals[0] + vals[1];
        else if (vals.Count == 1)
            firstTwo = vals[0];
        
        Console.WriteLine(sum - firstTwo);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Simplicity");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}