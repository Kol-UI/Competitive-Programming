// Digits
namespace CompetitiveProgramming.CodeForces.Digits;
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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long n = input[0];
            int d = input[1];
            
            List<int> v = new List<int> { 1 };
            
            if(d == 3 || d == 6 || d == 9 || n >= 3) v.Add(3);
            if(d == 5) v.Add(5);
            if(d == 7 || n >= 3) v.Add(7);
            if(d == 9 || (d == 3 && n >= 3) || (d == 6 && n >= 3) || n >= 6) v.Add(9);
            
            Console.WriteLine(string.Join(" ", v.Select(x => x.ToString()).ToArray()));
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
        StyleHelper.Title("Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}