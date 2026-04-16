// Alien Math
namespace CompetitiveProgramming.Kattis.AlienMath;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        string[] ds = Console.ReadLine().Split();
        string s = Console.ReadLine();
        
        int i = 0;
        int[] digs = new int[s.Length];
        int digCount = 0;
        
        while (i < s.Length)
        {
            for (int dig = 0; dig < ds.Length; dig++)
            {
                if (s.Substring(i).StartsWith(ds[dig]))
                {
                    digs[digCount++] = dig;
                    i += ds[dig].Length;
                    break;
                }
            }
        }
        
        long ans = 0;
        for (int j = 0; j < digCount; j++)
        {
            ans += digs[j] * (long)Math.Pow(b, digCount - 1 - j);
        }
        
        Console.WriteLine(ans);
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
        StyleHelper.Title("Alien Math");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}