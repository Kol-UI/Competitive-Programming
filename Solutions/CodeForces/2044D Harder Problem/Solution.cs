// Harder Problem
namespace CompetitiveProgramming.CodeForces.HarderProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            SortedSet<int> s = new SortedSet<int>();
            for(int p = 1; p <= n; p++) s.Add(p);
            
            List<int> result = new List<int>();
            
            for(int p = 0; p < n; p++)
            {
                int value = s.Contains(a[p]) ? a[p] : s.Min;
                s.Remove(value);
                result.Add(value);
            }
            
            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString()).ToArray()));
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
        StyleHelper.Title("Harder Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}