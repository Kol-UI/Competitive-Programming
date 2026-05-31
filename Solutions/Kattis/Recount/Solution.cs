// Recount
namespace CompetitiveProgramming.Kattis.Recount;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> cnt = new Dictionary<string, int>();
        
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "***") break;
            
            if (!cnt.ContainsKey(s))
                cnt[s] = 0;
            cnt[s]++;
        }
        
        int mx = 0;
        bool uniq = false;
        string mxs = "";
        
        foreach (var kvp in cnt)
        {
            if (kvp.Value > mx)
            {
                mx = kvp.Value;
                uniq = true;
                mxs = kvp.Key;
            }
            else if (kvp.Value == mx)
            {
                uniq = false;
            }
        }
        
        if (uniq)
            Console.WriteLine(mxs);
        else
            Console.WriteLine("Runoff!");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Recount");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}