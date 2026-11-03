// Flip Flow
namespace CompetitiveProgramming.Kattis.FlipFlow;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        string line1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line1)) return;

        string[] parts1 = line1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        long t = long.Parse(parts1[0]);
        long s = long.Parse(parts1[1]);
        int n = int.Parse(parts1[2]);

        string line2 = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(line2)) line2 = Console.ReadLine();

        string[] parts2 = line2.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        while (parts2.Length < n)
        {
            string[] nextParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] temp = new string[parts2.Length + nextParts.Length];
            parts2.CopyTo(temp, 0);
            nextParts.CopyTo(temp, parts2.Length);
            parts2 = temp;
        }

        long[] a = new long[n + 1];
        for (int i = 0; i < n; i++)
        {
            a[i] = long.Parse(parts2[i]);
        }
        a[n] = t;

        long tp = 0;
        long lw = s;

        for (int i = 0; i < n; i++)
        {
            long x = a[i];
            long y = a[i + 1];

            long temp = tp;
            tp = lw;
            lw = temp;

            long m = Math.Min(tp, y - x);
            tp -= m;
            lw += m;
        }

        Console.WriteLine(tp);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Flip Flow");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}