// Sauna
namespace CompetitiveProgramming.Kattis.Sauna;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    const int mxN = 200005;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] p = new int[mxN + 2];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int l = int.Parse(input[0]);
            int r = int.Parse(input[1]);

            p[l]++;
            p[r + 1]--;
        }

        int cnt = 0;
        int cur = 0;
        int lo = -1;

        for (int i = 0; i <= mxN; i++)
        {
            cur += p[i];
            if (cur == n)
            {
                cnt++;
                if (lo == -1) lo = i;
            }
        }

        if (cnt > 0)
            Console.WriteLine($"{cnt} {lo}");
        else
            Console.WriteLine("bad news");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sauna");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}