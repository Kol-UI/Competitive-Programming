// Nimionese
namespace CompetitiveProgramming.Kattis.Nimionese;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Solution
{
    static string Near(char c, List<string> lst)
    {
        string mn = lst[0];
        foreach (string s in lst)
        {
            if (Math.Abs(c - s[0]) < Math.Abs(c - mn[0]))
                mn = s;
            else if (Math.Abs(c - s[0]) == Math.Abs(c - mn[0]) && s[0] < mn[0])
                mn = s;
        }
        return mn;
    }

    static void Main()
    {
        string[] s = Console.ReadLine().Split();

        List<string> HARD = new List<string> { "b", "c", "d", "g", "k", "n", "p", "t" };
        foreach (string w in s)
        {
            string[] syl = w.Split('-');
            string x = syl[0];
            string n = Near(char.ToLower(x[0]), HARD);
            if (char.ToLower(x[0]) != x[0])
                n = n.ToUpper();
            x = n + x.Substring(1);
            for (int i = 1; i < syl.Length; i++)
            {
                string y = syl[i];
                string res = y;
                foreach (string c in HARD)
                    res = res.Replace(c, x[0].ToString().ToLower());
                x += res;
            }
            if (HARD.Contains(x[x.Length - 1].ToString().ToLower()))
                x += Near(char.ToLower(x[x.Length - 1]), new List<string> { "ah", "oh", "uh" });
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Nimionese");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}