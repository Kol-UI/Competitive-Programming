// Fun Game
namespace CompetitiveProgramming.CodeForces.FunGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        int q = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < q; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine()!;
            string t = Console.ReadLine()!;
            
            bool possible = true;
            
            for(int p = 0; p < s.Length; p++)
            {
                if(s[p] == '1') break;
                if(t[p] == '1')
                {
                    possible = false;
                    break;
                }
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fun Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}