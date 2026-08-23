// Pencil Crayons
namespace CompetitiveProgramming.Kattis.PencilCrayons;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);

        int ans = 0;

        for (int i = 0; i < n; i++)
        {
            string[] ws = Console.ReadLine().Split();
            Dictionary<string, int> cnt = new Dictionary<string, int>();

            foreach (string w in ws)
            {
                if (!cnt.ContainsKey(w))
                    cnt[w] = 0;
                cnt[w]++;
            }

            foreach (var kvp in cnt)
            {
                ans += kvp.Value - 1;
            }
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pencil Crayons");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}