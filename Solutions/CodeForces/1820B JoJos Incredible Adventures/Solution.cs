// JoJo's Incredible Adventures
namespace CompetitiveProgramming.CodeForces.JoJosIncredibleAdventures;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            long len = s.Length;
            long mx = 0, cnt = 0;
            bool z = false;
            
            for(long p = 0; p < 2 * len; p++)
            {
                if(s[(int)(p % len)] == '1')
                {
                    cnt++;
                }
                else
                {
                    z = true;
                    cnt = 0;
                }
                if(cnt > mx) mx = cnt;
            }
            
            long res;
            if(z)
            {
                long a = (mx + 1) / 2;
                long b = (mx + 2) / 2;
                res = a * b;
            }
            else
            {
                res = len * len;
            }
            
            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("JoJo's Incredible Adventures");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}