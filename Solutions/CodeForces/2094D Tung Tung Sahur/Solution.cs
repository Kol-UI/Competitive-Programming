// Tung Tung Sahur
namespace CompetitiveProgramming.CodeForces.TungTungSahur;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            a += '_';
            b += '_';
            
            List<(char, int)> va = new List<(char, int)>();
            List<(char, int)> vb = new List<(char, int)>();
            
            int cnt = 1;
            for(int p = 1; p < a.Length; p++)
            {
                if(a[p - 1] == a[p])
                {
                    cnt++;
                }
                else
                {
                    va.Add((a[p - 1], cnt));
                    cnt = 1;
                }
            }
            
            cnt = 1;
            for(int p = 1; p < b.Length; p++)
            {
                if(b[p - 1] == b[p])
                {
                    cnt++;
                }
                else
                {
                    vb.Add((b[p - 1], cnt));
                    cnt = 1;
                }
            }
            
            bool res = true;
            if(va.Count != vb.Count)
            {
                res = false;
            }
            
            for(int p = 0; p < va.Count && res; p++)
            {
                if(va[p].Item1 != vb[p].Item1)
                {
                    res = false;
                }
                if(vb[p].Item2 < va[p].Item2 || vb[p].Item2 > 2 * va[p].Item2)
                {
                    res = false;
                }
            }
            
            Console.WriteLine(res ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tung Tung Sahur");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}