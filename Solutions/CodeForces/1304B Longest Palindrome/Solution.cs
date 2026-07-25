// Longest Palindrome
namespace CompetitiveProgramming.CodeForces.LongestPalindrome;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        List<string> f = new List<string>();
        List<string> g = new List<string>();
        Dictionary<string, int> sms = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            string y = new string(arr);

            if (sms.ContainsKey(y) && sms[y] > 0)
            {
                sms[y]--;
                f.Add(x);
                g.Add(y);
            }
            else
            {
                if (!sms.ContainsKey(x))
                    sms[x] = 0;
                sms[x]++;
            }
        }

        string middle = "";
        foreach (var kvp in sms)
        {
            if (kvp.Value > 0)
            {
                string x = kvp.Key;
                char[] arr = x.ToCharArray();
                Array.Reverse(arr);
                string y = new string(arr);
                if (x == y)
                {
                    middle = x;
                    break;
                }
            }
        }

        long len = (f.Count + g.Count) * m + middle.Length;
        Console.WriteLine(len);

        foreach (string s in f)
            Console.Write(s);
        Console.Write(middle);

        for (int i = g.Count - 1; i >= 0; i--)
            Console.Write(g[i]);

        Console.WriteLine();
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Palindrome");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}