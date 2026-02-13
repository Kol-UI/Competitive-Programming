// Mirror in the String
namespace CompetitiveProgramming.CodeForces.MirrorintheString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine() + "z";
            
            string v = new string(s[0], 2);
            int len = 0;
            
            for(int p = 0; p + 1 < s.Length; p++)
            {
                len = p + 1;
                if(s[p] < s[p + 1]) break;
            }
            
            string t_str = s.Substring(0, len);
            string w = t_str + new string(t_str.Reverse().ToArray());
            
            Console.WriteLine(w.CompareTo(v) < 0 ? w : v);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mirror in the String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}