// Mean Words
namespace CompetitiveProgramming.Kattis.MeanWords;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        string[] s = new string[n];
        for (int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine()!;
        }

        int maxLen = s.Max(str => str.Length);
        int[] sm = new int[maxLen];
        int[] nm = new int[maxLen];

        foreach (string a in s)
        {
            for (int i = 0; i < a.Length; i++)
            {
                nm[i]++;
                sm[i] += a[i];
            }
        }

        for (int i = 0; i < sm.Length; i++)
        {
            Console.Write((char)(sm[i] / nm[i]));
        }
        Console.WriteLine();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mean Words");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}