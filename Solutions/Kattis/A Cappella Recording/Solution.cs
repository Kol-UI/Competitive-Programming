// A Cappella Recording
namespace CompetitiveProgramming.Kattis.ACappellaRecording;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using System;

public class Solution
{
    public static void Main()
    {
        string line1 = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(line1)) return;

        string[] parts1 = line1.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(parts1[0]);
        long d = long.Parse(parts1[1]);

        long[] a = new long[n];
        int count = 0;

        while (count < n)
        {
            string line = Console.ReadLine()!;
            if (line == null) break;

            string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in parts)
            {
                if (count < n)
                {
                    a[count++] = long.Parse(p);
                }
            }
        }

        Array.Sort(a);

        int ans = 0;
        int i = 0;
        while (i < n)
        {
            ans++;
            int j = i;
            while (j < n && a[j] - a[i] <= d)
            {
                j++;
            }
            i = j;
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Cappella Recording");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}