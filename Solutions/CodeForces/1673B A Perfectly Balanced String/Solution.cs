// A Perfectly Balanced String?
namespace CompetitiveProgramming.CodeForces.APerfectlyBalancedString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            string s = Console.ReadLine()!;
            
            HashSet<char> charSet = new HashSet<char>();
            foreach(char c in s) charSet.Add(c);
            
            int k = charSet.Count;
            bool result = true;
            
            for(int p = k; result && p < s.Length; p++)
            {
                if(s[p - k] != s[p]) result = false;
            }
            
            Console.WriteLine(result ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Perfectly Balanced String?");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}