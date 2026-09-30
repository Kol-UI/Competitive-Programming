// Restricted RPS
namespace CompetitiveProgramming.CodeForces.RestrictedRPS;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Text;

class Program
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        int t = int.Parse(tLine.Trim());
        StringBuilder sb = new StringBuilder();

        while (t-- > 0)
        {
            string nLine = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nLine)) nLine = Console.ReadLine();
            int n = int.Parse(nLine.Trim());

            string abcLine = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(abcLine)) abcLine = Console.ReadLine();
            string[] abc = abcLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(abc[0]);
            int b = int.Parse(abc[1]);
            int c = int.Parse(abc[2]);

            string g = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(g)) g = Console.ReadLine();

            int cnt = 0;
            char[] h = new char[g.Length];

            for (int p = 0; p < g.Length; p++)
            {
                if (g[p] == 'R')
                {
                    if (b > 0) { cnt++; b--; h[p] = 'P'; }
                    else { h[p] = '_'; }
                }
                else if (g[p] == 'P')
                {
                    if (c > 0) { cnt++; c--; h[p] = 'S'; }
                    else { h[p] = '_'; }
                }
                else if (g[p] == 'S')
                {
                    if (a > 0) { cnt++; a--; h[p] = 'R'; }
                    else { h[p] = '_'; }
                }
            }

            for (int p = 0; p < h.Length; p++)
            {
                if (h[p] != '_') continue;
                if (a > 0) { h[p] = 'R'; a--; }
                else if (b > 0) { h[p] = 'P'; b--; }
                else if (c > 0) { h[p] = 'S'; c--; }
            }

            if (2 * cnt >= n)
            {
                sb.AppendLine("YES");
                sb.AppendLine(new string(h));
            }
            else
            {
                sb.AppendLine("NO");
            }
        }

        Console.Write(sb.ToString());
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Restricted RPS");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}