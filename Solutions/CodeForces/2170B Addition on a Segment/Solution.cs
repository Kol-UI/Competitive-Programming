// Addition on a Segment
namespace CompetitiveProgramming.CodeForces.AdditiononaSegment;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string nLine = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(nLine)) nLine = Console.ReadLine();
            long n = long.Parse(nLine.Trim());

            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (parts.Length < n)
            {
                string[] nextParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] temp = new string[parts.Length + nextParts.Length];
                parts.CopyTo(temp, 0);
                nextParts.CopyTo(temp, parts.Length);
                parts = temp;
            }

            long s = -(n - 1);
            long cnt = 0;

            for (int p = 0; p < n; p++)
            {
                long x = long.Parse(parts[p]);
                s += x;
                if (x > 0) cnt++;
            }

            Console.WriteLine(s < cnt ? s : cnt);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Addition on a Segment");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}