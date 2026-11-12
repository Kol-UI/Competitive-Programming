// Glyph Recognition
namespace CompetitiveProgramming.Kattis.GlyphRecognition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Globalization;

class Solution
{
    struct Point
    {
        public double X, Y;
        public Point(double x = 0, double y = 0) { X = x; Y = y; }
        public double Dist() => Math.Sqrt(X * X + Y * Y);
    }

    const double EPS = 1e-8;
    const double M_PI = Math.PI;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            string[] xy = Console.ReadLine().Split();
            points[i] = new Point(
                double.Parse(xy[0], CultureInfo.InvariantCulture),
                double.Parse(xy[1], CultureInfo.InvariantCulture));
        }

        int opt = 3;
        double opta = 0.0;

        for (int k = 3; k <= 8; k++)
        {
            double alpha = 2 * M_PI / k;

            double amin = double.PositiveInfinity;
            double amax = double.NegativeInfinity;

            foreach (var p in points)
            {
                double ang = Math.Atan2(p.Y, p.X);
                if (ang < 0) ang += 2 * M_PI;

                int kdrant = (int)Math.Floor(ang / alpha);
                ang -= alpha * kdrant;

                double inner = Math.Abs(alpha / 2 - ang);
                double len = p.Dist();
                double t = len * Math.Cos(inner);

                double s = Math.Tan(alpha / 2) * t;
                double ar = s * t * k;

                amin = Math.Min(amin, ar);
                amax = Math.Max(amax, ar);
            }

            double a = amin / amax;
            if (a > opta)
            {
                opta = a;
                opt = k;
            }
        }

        Console.WriteLine(opt + " " + opta.ToString("F12", CultureInfo.InvariantCulture));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Glyph Recognition");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}