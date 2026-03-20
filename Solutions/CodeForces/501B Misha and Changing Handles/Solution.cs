// Misha and Changing Handles
namespace CompetitiveProgramming.CodeForces.MishaandChangingHandles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        List<(string, string)> requests = new List<(string, string)>();
        HashSet<string> names = new HashSet<string>();
        Dictionary<string, string> newToOld = new Dictionary<string, string>();
        
        for(int p = 0; p < n; p++)
        {
            var parts = Console.ReadLine().Split();
            string original = parts[0];
            string requested = parts[1];
            
            if(names.Contains(requested)) continue;
            
            names.Add(original);
            names.Add(requested);
            
            if(newToOld.ContainsKey(original))
            {
                string oldOriginal = newToOld[original];
                newToOld.Remove(original);
                newToOld[requested] = oldOriginal;
            }
            else
            {
                newToOld[requested] = original;
            }
        }
        
        Console.WriteLine(newToOld.Count);
        foreach(var pair in newToOld)
        {
            Console.WriteLine($"{pair.Value} {pair.Key}");
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
        StyleHelper.Title("Misha and Changing Handles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}