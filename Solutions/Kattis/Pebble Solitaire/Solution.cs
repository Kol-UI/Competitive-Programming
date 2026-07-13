// Pebble Solitaire
namespace CompetitiveProgramming.Kattis.PebbleSolitaire;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static int PopCount(int x)
    {
        int n = 0;
        while (x > 0)
        {
            n += x & 1;
            x >>= 1;
        }
        return n;
    }

    static int MinLeft(int x)
    {
        int ans = PopCount(x);

        for (int i = 0; i < 10; i++)
        {
            if ((x & (1 << i)) != 0 && (x & (1 << (i + 1))) != 0 && (x & (1 << (i + 2))) == 0)
            {
                int newX = x ^ (1 << i) ^ (1 << (i + 1)) ^ (1 << (i + 2));
                int val = MinLeft(newX);
                if (val < ans) ans = val;
            }
            else if ((x & (1 << i)) == 0 && (x & (1 << (i + 1))) != 0 && (x & (1 << (i + 2))) != 0)
            {
                int newX = x ^ (1 << i) ^ (1 << (i + 1)) ^ (1 << (i + 2));
                int val = MinLeft(newX);
                if (val < ans) ans = val;
            }
        }

        return ans;
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for (int idx = 0; idx < t; idx++)
        {
            string s = Console.ReadLine();
            int x = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'o')
                    x |= (1 << i);
            }

            Console.WriteLine(MinLeft(x));
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
        StyleHelper.Title("Pebble Solitaire");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}