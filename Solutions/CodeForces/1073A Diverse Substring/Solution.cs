// Diverse Substring
namespace CompetitiveProgramming.CodeForces.DiverseSubstring;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    const int N = 26;

    static bool Diverse(string s)
    {
        int[] cnt = new int[N];
        for (int p = 0; p < s.Length; p++)
        {
            cnt[s[p] - 'a']++;
            if (2 * cnt[s[p] - 'a'] > s.Length)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        int len = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        string ans = "";

        for (int p = 0; p < s.Length; p++)
        {
            if (ans.Length > 0) break;
            for (int q = 2; q <= len; q++)
            {
                if (p + q > s.Length) break;
                string t = s.Substring(p, q);
                if (Diverse(t))
                {
                    ans = t;
                    break;
                }
            }
        }

        if (ans.Length > 0)
        {
            Console.WriteLine("YES");
            Console.WriteLine(ans);
        }
        else
        {
            Console.WriteLine("NO");
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
        StyleHelper.Title("Diverse Substring");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}