// Different is Good
namespace CompetitiveProgramming.CodeForces.DifferentisGood;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        const int N = 26;
        long n = long.Parse(Console.ReadLine());
        string s = Console.ReadLine()!;
        
        if (s.Length > N)
        {
            Console.WriteLine("-1");
            return;
        }
        
        HashSet<char> c = new HashSet<char>();
        for (int p = 0; p < s.Length; p++)
        {
            c.Add(s[p]);
        }
        
        Console.WriteLine(s.Length - c.Count);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Different is Good");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}