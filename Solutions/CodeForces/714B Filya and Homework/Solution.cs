// Filya and Homework
namespace CompetitiveProgramming.CodeForces.FilyaandHomework;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        long n = long.Parse(nLine.Trim());
        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        SortedSet<long> s = new SortedSet<long>();
        for (int i = 0; i < n; i++)
        {
            s.Add(long.Parse(parts[i]));
        }

        if (s.Count <= 2)
        {
            Console.WriteLine("YES");
            return;
        }

        if (s.Count >= 4)
        {
            Console.WriteLine("NO");
            return;
        }

        long[] elements = s.ToArray();
        long a = elements[0];
        long b = elements[1];
        long c = elements[2];

        Console.WriteLine(2 * b == a + c ? "YES" : "NO");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Filya and Homework");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}