// Bus Lines
namespace CompetitiveProgramming.Kattis.BusLines;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);

        if (n - 1 <= m && m <= 2 * n - 3)
        {
            List<(int, int)> ans = new List<(int, int)>();
            int s = 1;
            int msm = 0;
            while (ans.Count < m)
            {
                for (int i = s + 1; i <= n; i++)
                {
                    if (s + i <= msm) continue;
                    ans.Add((s, i));
                    msm = s + i;
                    if (ans.Count == m) break;
                }
                s++;
            }
            foreach (var (x, y) in ans)
                Console.WriteLine(x + " " + y);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bus Lines");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}