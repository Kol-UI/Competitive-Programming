// Snow Walking Robot
namespace CompetitiveProgramming.CodeForces.SnowWalkingRobot;
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
        string qLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(qLine)) return;

        int q = int.Parse(qLine.Trim());
        StringBuilder sb = new StringBuilder();

        while (q-- > 0)
        {
            string s = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(s)) s = Console.ReadLine();

            long u = 0, d = 0, l = 0, r = 0;
            for (int p = 0; p < s.Length; p++)
            {
                if (s[p] == 'U') u++;
                else if (s[p] == 'D') d++;
                else if (s[p] == 'L') l++;
                else if (s[p] == 'R') r++;
            }

            u = (u < d) ? u : d;
            d = u;
            r = (l < r) ? l : r;
            l = r;

            if (u <= 0 && l > 0) { l = r = 1; }
            if (r <= 0 && u > 0) { u = d = 1; }

            sb.AppendLine((u + d + l + r).ToString());
            sb.Append('U', (int)u);
            sb.Append('L', (int)l);
            sb.Append('D', (int)d);
            sb.Append('R', (int)r);
            sb.AppendLine();
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
        StyleHelper.Title("Snow Walking Robot");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}