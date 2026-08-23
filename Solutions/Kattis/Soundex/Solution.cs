// Soundex
namespace CompetitiveProgramming.Kattis.Soundex;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static string[] chlist = { "BFPV", "CGJKQSXZ", "DT", "L", "MN", "R" };

    static int GetCode(char c)
    {
        for (int i = 0; i < chlist.Length; i++)
        {
            if (chlist[i].Contains(c))
                return i + 1;
        }
        return 0;
    }

    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            List<int> a = new List<int>();
            foreach (char c in line)
                a.Add(GetCode(c));

            List<int> b = new List<int>();
            int prev = 0;
            foreach (int x in a)
            {
                if (prev != x)
                    b.Add(x);
                prev = x;
            }

            string result = "";
            foreach (int x in b)
            {
                if (x != 0)
                    result += x.ToString();
            }

            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Soundex");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}