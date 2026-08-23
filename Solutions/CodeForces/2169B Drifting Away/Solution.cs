// Drifting Away
namespace CompetitiveProgramming.CodeForces.DriftingAway;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            long mxcnt = 0;
            long cnt = 0;

            for (long p = 1; p < s.Length; p++)
            {
                if (s[(int)(p - 1)] == '>' && s[(int)p] == '*')
                    mxcnt = -1;
                else if (s[(int)(p - 1)] == '>' && s[(int)p] == '<')
                    mxcnt = -1;
                else if (s[(int)(p - 1)] == '*' && s[(int)p] == '<')
                    mxcnt = -1;
                else if (s[(int)(p - 1)] == '*' && s[(int)p] == '*')
                    mxcnt = -1;
            }

            cnt = 0;
            for (long p = 0; mxcnt >= 0 && p < s.Length; p++)
            {
                if (s[(int)p] == '<')
                    cnt = 0;
                else
                {
                    cnt++;
                    if (cnt > mxcnt) mxcnt = cnt;
                }
            }

            cnt = 0;
            for (long p = 0; mxcnt >= 0 && p < s.Length; p++)
            {
                if (s[(int)p] == '>')
                    cnt = 0;
                else
                {
                    cnt++;
                    if (cnt > mxcnt) mxcnt = cnt;
                }
            }

            Console.WriteLine(mxcnt);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Drifting Away");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
