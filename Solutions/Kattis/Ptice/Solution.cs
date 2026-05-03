// Ptice
namespace CompetitiveProgramming.Kattis.Ptice;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        int a = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 3 == 0 && s[i] == 'A') a++;
            if (i % 3 == 1 && s[i] == 'B') a++;
            if (i % 3 == 2 && s[i] == 'C') a++;
        }

        int b = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 4 == 0 && s[i] == 'B') b++;
            if (i % 4 == 1 && s[i] == 'A') b++;
            if (i % 4 == 2 && s[i] == 'B') b++;
            if (i % 4 == 3 && s[i] == 'C') b++;
        }

        int g = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 6 == 0 && s[i] == 'C') g++;
            if (i % 6 == 1 && s[i] == 'C') g++;
            if (i % 6 == 2 && s[i] == 'A') g++;
            if (i % 6 == 3 && s[i] == 'A') g++;
            if (i % 6 == 4 && s[i] == 'B') g++;
            if (i % 6 == 5 && s[i] == 'B') g++;
        }

        int maximum = Math.Max(Math.Max(a, b), g);
        Console.WriteLine(maximum);

        if (a == maximum) Console.WriteLine("Adrian");
        if (b == maximum) Console.WriteLine("Bruno");
        if (g == maximum) Console.WriteLine("Goran");
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
        StyleHelper.Title("Ptice");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}