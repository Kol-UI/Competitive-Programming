// Streets Ahead
namespace CompetitiveProgramming.Kattis.StreetsAhead;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var pos = new Dictionary<string, int>();

        var tokens = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (tokens == null || tokens.Length < 2) return;

        int n = int.Parse(tokens[0]);
        int q = int.Parse(tokens[1]);

        for (int i = 0; i < n; ++i)
        {
            string s = Console.ReadLine()?.Trim() ?? "";
            pos[s] = i;
        }

        while (q-- > 0)
        {
            var query = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (query == null || query.Length < 2) continue;

            string a = query[0];
            string b = query[1];

            int i = pos[a];
            int j = pos[b];

            Console.WriteLine(Math.Abs(i - j) - 1);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Streets Ahead");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}