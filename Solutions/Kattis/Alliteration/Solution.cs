// Alliteration
namespace CompetitiveProgramming.Kattis.Alliteration;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string[] ws = Console.ReadLine().Split();
            Dictionary<char, int> cnt = new Dictionary<char, int>();
            
            foreach (string w in ws)
            {
                char firstChar = w[0];
                if (!cnt.ContainsKey(firstChar))
                    cnt[firstChar] = 0;
                cnt[firstChar]++;
            }
            
            var maxCount = cnt.Values.Max();
            var bestChar = cnt.Where(kv => kv.Value == maxCount).Min(kv => kv.Key);
            
            Console.WriteLine(bestChar);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alliteration");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}