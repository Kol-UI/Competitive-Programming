// Word Cloud
namespace CompetitiveProgramming.Kattis.WordCloud;
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
        int tc = 1;
        while (true)
        {
            string[] firstLine = Console.ReadLine().Split();
            int W = int.Parse(firstLine[0]);
            int n = int.Parse(firstLine[1]);

            if (W + n == 0) break;

            List<(string name, int c)> ws = new List<(string, int)>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                ws.Add((input[0], int.Parse(input[1])));
            }

            int cmax = 0;
            foreach (var (name, c) in ws)
            {
                if (c > cmax) cmax = c;
            }

            int ans = 0;
            int cr_width = 0;
            int cr_height = 0;

            foreach (var (w, c) in ws)
            {
                int P = 8 + (40 * (c - 4) + cmax - 5) / (cmax - 4);
                int width = (9 * w.Length * P + 15) / 16;

                if (cr_width > 0 && cr_width + 10 + width <= W)
                {
                    cr_width += 10 + width;
                    if (P > cr_height) cr_height = P;
                }
                else
                {
                    ans += cr_height;
                    cr_width = width;
                    cr_height = P;
                }
            }

            ans += cr_height;
            Console.WriteLine($"CLOUD {tc}: {ans}");
            tc++;
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Word Cloud");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}