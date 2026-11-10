// Field Trip
namespace CompetitiveProgramming.Kattis.FieldTrip;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        long[] p = new long[n + 1];
        for (int i = 0; i < n; i++)
            p[i + 1] = p[i] + a[i];

        long S = p[n];

        if (S % 3 != 0)
        {
            Console.WriteLine(-1);
            return;
        }

        int idx1 = -1;
        for (int i = 0; i < n; i++)
        {
            if (p[i + 1] * 3 == S)
            {
                idx1 = i;
                break;
            }
        }
        if (idx1 == -1)
        {
            Console.WriteLine(-1);
            return;
        }

        int idx2 = -1;
        for (int j = idx1 + 1; j < n; j++)
        {
            if ((p[j + 1] - p[idx1 + 1]) * 3 == S)
            {
                idx2 = j;
                break;
            }
        }
        if (idx2 == -1)
        {
            Console.WriteLine(-1);
            return;
        }

        Console.WriteLine((idx1 + 1) + " " + (idx2 + 1));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Field Trip");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}