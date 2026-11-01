// White-Black Balanced Subtrees
namespace CompetitiveProgramming.CodeForces.WhiteBlackBalancedSubtrees;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static long Dfs(long node, List<long>[] g, string s, ref long cnt)
    {
        long total = (s[(int)node] == 'W' ? 1 : 0) - (s[(int)node] == 'B' ? 1 : 0);

        foreach (long x in g[node])
        {
            total += Dfs(x, g, s, ref cnt);
        }

        if (total == 0) cnt++;

        return total;
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            List<long>[] g = new List<long>[n + 1];
            for (long p = 0; p <= n; p++) g[p] = new List<long>();

            string[] vals = Console.ReadLine().Split();
            for (long p = 2; p <= n; p++)
            {
                long x = long.Parse(vals[p - 2]);
                g[x].Add(p);
            }

            string s = "_" + Console.ReadLine();

            long cnt = 0;
            Dfs(1, g, s, ref cnt);
            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("White-Black Balanced Subtrees");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}