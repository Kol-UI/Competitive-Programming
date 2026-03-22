// A Little Leftover Pizza
namespace CompetitiveProgramming.Kattis.ALittleLeftoverPizza;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

public class Solution
{
    public static void Main()
    {
        string lineN = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(lineN)) return;
        
        int n = int.Parse(lineN.Trim());

        int ss = 0, sm = 0, sl = 0;

        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(row)) continue;

            string[] parts = row.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            char c = parts[0][0];
            int x = int.Parse(parts[1]);

            switch (c)
            {
                case 'S':
                    ss += x;
                    break;
                case 'M':
                    sm += x;
                    break;
                case 'L':
                    sl += x;
                    break;
            }
        }

        int result = ((ss + 5) / 6) + ((sm + 7) / 8) + ((sl + 11) / 12);
        Console.WriteLine(result);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Little Leftover Pizza");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}