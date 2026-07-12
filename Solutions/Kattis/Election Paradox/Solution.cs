// Election Paradox
namespace CompetitiveProgramming.Kattis.ElectionParadox;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(a);

        long ans = 0;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            ans += a[i] / 2;
        }

        for (int i = (n + 1) / 2; i < n; i++)
        {
            ans += a[i];
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Election Paradox");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}