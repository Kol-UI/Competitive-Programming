// Kaleidoscopic Palindromes
namespace CompetitiveProgramming.Kattis.KaleidoscopicPalindromes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool Check(int x, int j)
    {
        List<int> a = new List<int>();
        int pw = 1;
        while (pw <= x)
        {
            pw *= j;
        }

        pw /= j;

        while (pw > 0)
        {
            int d = x / pw;
            x -= d * pw;
            a.Add(d);
            pw /= j;
        }

        return a.SequenceEqual(Enumerable.Reverse(a));
    }

    static void Main()
    {
        string[] input = Console.ReadLine()!.Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int k = int.Parse(input[2]);

        int ans = 0;
        for (int x = a; x <= b; x++)
        {
            bool isValid = true;
            for (int j = 2; j <= k; j++)
            {
                if (!Check(x, j))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                ans++;
            }
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kaleidoscopic Palindromes");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}