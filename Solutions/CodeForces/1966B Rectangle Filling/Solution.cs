// Rectangle Filling
namespace CompetitiveProgramming.CodeForces.RectangleFilling;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);

            int wmnr = (int)n + 1;
            int bmnr = (int)n + 1;
            int wmxr = -1;
            int bmxr = -1;
            int wmnc = (int)m + 1;
            int bmnc = (int)m + 1;
            int wmxc = -1;
            int bmxc = -1;

            for (long row = 0; row < n; row++)
            {
                string s = Console.ReadLine();
                for (int col = 0; col < s.Length; col++)
                {
                    if (s[col] == 'W')
                    {
                        if (row < wmnr) wmnr = (int)row;
                        if (row > wmxr) wmxr = (int)row;
                        if (col < wmnc) wmnc = col;
                        if (col > wmxc) wmxc = col;
                    }
                    else if (s[col] == 'B')
                    {
                        if (row < bmnr) bmnr = (int)row;
                        if (row > bmxr) bmxr = (int)row;
                        if (col < bmnc) bmnc = col;
                        if (col > bmxc) bmxc = col;
                    }
                }
            }

            bool possible = false;
            if (wmnr == 0 && wmxr == n - 1 && wmnc == 0 && wmxc == m - 1)
                possible = true;
            if (bmnr == 0 && bmxr == n - 1 && bmnc == 0 && bmxc == m - 1)
                possible = true;

            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Rectangle Filling");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
