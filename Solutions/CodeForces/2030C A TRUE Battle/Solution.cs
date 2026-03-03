// A TRUE Battle
namespace CompetitiveProgramming.CodeForces.ATRUEBattle;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine()!;
            
            bool win = false;
            for(int p = 0; p < s.Length; p++)
            {
                if(s[p] == '0') continue;
                if(p == 0 || p == n - 1 || s[p - 1] == s[p])
                {
                    win = true;
                    break;
                }
            }
            
            Console.WriteLine(win ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A TRUE Battle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}