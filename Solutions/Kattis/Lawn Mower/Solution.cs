// Lawn Mower
namespace CompetitiveProgramming.Kattis.LawnMower;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            string[] firstLine = Console.ReadLine().Split();
            int nx = int.Parse(firstLine[0]);
            int ny = int.Parse(firstLine[1]);
            double w = double.Parse(firstLine[2]);

            if (nx == 0 && ny == 0) break;

            double[] xs = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Array.Sort(xs);
            double[] ys = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Array.Sort(ys);

            List<(double, double)> xseg = new List<(double, double)>();
            foreach (double x in xs)
                xseg.Add((x - w / 2, x + w / 2));

            bool fail = false;
            for (int i = 0; i < xseg.Count - 1; i++)
            {
                if (xseg[i + 1].Item1 > xseg[i].Item2)
                {
                    fail = true;
                    break;
                }
            }

            if (fail || xseg[0].Item1 > 0.0 || xseg[xseg.Count - 1].Item2 < 75.0)
            {
                Console.WriteLine("NO");
                continue;
            }

            List<(double, double)> yseg = new List<(double, double)>();
            foreach (double y in ys)
                yseg.Add((y - w / 2, y + w / 2));

            fail = false;
            for (int i = 0; i < yseg.Count - 1; i++)
            {
                if (yseg[i + 1].Item1 > yseg[i].Item2)
                {
                    fail = true;
                    break;
                }
            }

            if (fail || yseg[0].Item1 > 0.0 || yseg[yseg.Count - 1].Item2 < 100.0)
            {
                Console.WriteLine("NO");
                continue;
            }

            Console.WriteLine("YES");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lawn Mower");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}