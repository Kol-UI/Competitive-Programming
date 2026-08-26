// Fear of the Dark
namespace CompetitiveProgramming.CodeForces.FearoftheDark;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static double Dist((double x, double y) u, (double x, double y) v)
    {
        return Math.Sqrt((u.x - v.x) * (u.x - v.x) + (u.y - v.y) * (u.y - v.y));
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine() ?? "0");
        while (t-- > 0)
        {
            var line1 = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var line2 = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var line3 = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (line1 == null || line2 == null || line3 == null) break;

            (double x, double y) h = (double.Parse(line1[0]), double.Parse(line1[1]));
            (double x, double y) a = (double.Parse(line2[0]), double.Parse(line2[1]));
            (double x, double y) b = (double.Parse(line3[0]), double.Parse(line3[1]));

            double za = Dist((0.0, 0.0), a);
            double zb = Dist((0.0, 0.0), b);
            double ha = Dist(h, a);
            double hb = Dist(h, b);
            double ab = Dist(a, b) / 2.0;

            double res = (za > ha) ? za : ha;
            double cand = (zb > hb) ? zb : hb; 
            res = (res < cand) ? res : cand;

            cand = (za > ab) ? za : ab; 
            cand = (cand > hb) ? cand : hb; 
            res = (cand < res) ? cand : res;

            cand = (zb > ab) ? zb : ab; 
            cand = (cand > ha) ? cand : ha; 
            res = (cand < res) ? cand : res;

            Console.WriteLine($"{res:F8}");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fear of the Dark");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}