// ICPC Awards
namespace CompetitiveProgramming.Kattis.ICPCAwards;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> seen = new HashSet<string>();
        
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string s1 = input[0];
            string s2 = input[1];
            
            if (!seen.Contains(s1) && count < 12)
            {
                Console.WriteLine($"{s1} {s2}");
                count++;
            }
            seen.Add(s1);
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
        StyleHelper.Title("ICPC Awards");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}