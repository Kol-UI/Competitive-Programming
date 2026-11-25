// Make a Power of Two
namespace CompetitiveProgramming.CodeForces.MakeaPowerofTwo;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static int GetDist(string target, string s)
    {
        int a = 0, b = 0, cnt = 0;
        while (a < target.Length || b < s.Length)
        {
            if (a >= target.Length) { b++; cnt++; }
            else if (b >= s.Length) { a++; cnt++; }
            else if (target[a] == s[b]) { a++; b++; }
            else { b++; cnt++; }
        }
        return cnt;
    }

    static void Main()
    {
        List<string> vs = new List<string>();
        long x = 1;
        for (long p = 1; p < 63; p++)
        {
            vs.Add(x.ToString());
            x *= 2;
        }

        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            long res = 100;
            for (int p = 0; p < vs.Count; p++)
            {
                int dist = GetDist(vs[p], s);
                if (dist < res) res = dist;
            }
            Console.WriteLine(res);
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
        StyleHelper.Title("Make a Power of Two");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}