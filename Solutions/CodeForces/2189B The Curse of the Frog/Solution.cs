// The Curse of the Frog
namespace CompetitiveProgramming.CodeForces.TheCurseoftheFrog;
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
            string[] nx = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(nx[0]);
            long x = long.Parse(nx[1]);

            long mxlen = 0;
            for (int p = 0; p < n; p++)
            {
                string[] abc = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                long a = long.Parse(abc[0]);
                long b = long.Parse(abc[1]);
                long c = long.Parse(abc[2]);

                x -= (a * (b - 1));
                long len = (a * b - c);
                mxlen = mxlen > len ? mxlen : len;
            }

            long mncnt = -1;
            if (x <= 0)
            {
                mncnt = 0;
            }
            else if (mxlen > 0)
            {
                mncnt = (x + mxlen - 1) / mxlen;
            }

            Console.WriteLine(mncnt);
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
        StyleHelper.Title("The Curse of the Frog");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}