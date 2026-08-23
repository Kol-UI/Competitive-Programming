// Flow Layout
namespace CompetitiveProgramming.Kattis.FlowLayout;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int m = int.Parse(line);
            if (m == 0) break;

            int mw = 0;
            int cw = 0;
            int ch = 0;
            int mh = 0;

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                int w = int.Parse(input[0]);
                int h = int.Parse(input[1]);

                if (w == -1 || cw + w > m)
                {
                    mh += ch;
                    if (cw > mw) mw = cw;
                    ch = 0;
                    cw = 0;

                    if (w == -1) break;
                }

                cw += w;
                if (h > ch) ch = h;
            }

            Console.WriteLine($"{mw} x {mh}");
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
        StyleHelper.Title("Flow Layout");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}