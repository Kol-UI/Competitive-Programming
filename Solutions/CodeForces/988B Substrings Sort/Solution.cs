// Substrings Sort
namespace CompetitiveProgramming.CodeForces.SubstringsSort;
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
        int n = int.Parse(Console.ReadLine());
        List<string> v = new List<string>();
        
        for(int p = 0; p < n; p++)
        {
            v.Add(Console.ReadLine());
        }
        
        v.Sort((a, b) => a.Length.CompareTo(b.Length));
        
        bool possible = true;
        for(int p = 1; p < n; p++)
        {
            if(!v[p].Contains(v[p - 1]))
            {
                possible = false;
                break;
            }
        }
        
        if(possible)
        {
            Console.WriteLine("YES");
            foreach(string s in v)
            {
                Console.WriteLine(s);
            }
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Substrings Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}