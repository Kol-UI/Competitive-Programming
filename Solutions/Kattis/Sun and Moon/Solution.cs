// Sun and Moon
namespace CompetitiveProgramming.Kattis.SunandMoon;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int ds = int.Parse(firstLine[0]);
        int ys = int.Parse(firstLine[1]);

        string[] secondLine = Console.ReadLine().Split();
        int dm = int.Parse(secondLine[0]);
        int ym = int.Parse(secondLine[1]);

        int ans = 0;

        int ps = ys - ds;
        int pm = ym - dm;

        while (true)
        {
            int m = Math.Min(ps, pm);
            ps -= m;
            pm -= m;
            ans += m;

            if (ps == 0 && pm == 0)
                break;

            if (ps == 0)
                ps = ys;
            else if (pm == 0)
                pm = ym;
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sun and Moon");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}