// Compound Words
namespace CompetitiveProgramming.Kattis.CompoundWords;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> ws = new HashSet<string>();
        string line;
        
        while ((line = Console.ReadLine()) != null)
        {
            string[] words = line.Split();
            foreach (string w in words)
            {
                ws.Add(w);
            }
        }
        
        List<string> wsList = ws.ToList();
        HashSet<string> ans = new HashSet<string>();
        
        foreach (string w in wsList)
        {
            foreach (string v in wsList)
            {
                if (w != v)
                {
                    ans.Add(w + v);
                }
            }
        }
        
        foreach (string w in ans.OrderBy(x => x))
        {
            Console.WriteLine(w);
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Compound Words");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}