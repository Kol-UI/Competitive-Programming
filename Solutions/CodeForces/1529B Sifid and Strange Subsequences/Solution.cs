// Sifid and Strange Subsequences
namespace CompetitiveProgramming.CodeForces.SifidandStrangeSubsequences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            var v = new List<int>();
            int minPos = int.MaxValue;
            
            string[] input = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(input[i]);
                if (x <= 0)
                    v.Add(x);
                else
                    minPos = Math.Min(minPos, x);
            }
            
            v.Sort();
            int ans = v.Count;
            int mn = int.MaxValue - 1;
            
            for (int i = 1; i < v.Count; i++)
            {
                mn = Math.Min(mn, Math.Abs(v[i] - v[i - 1]));
            }
            
            if (v.Count == 1 && minPos != int.MaxValue)
                ans++;
            else if (mn >= minPos)
                ans++;
            
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sifid and Strange Subsequences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}