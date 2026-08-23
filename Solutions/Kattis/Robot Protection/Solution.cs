// Robot Protection
namespace CompetitiveProgramming.Kattis.RobotProtection;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

struct Point : IComparable<Point>
{
    public long X;
    public long Y;

    public Point(long x = 0, long y = 0)
    {
        X = x;
        Y = y;
    }

    public int CompareTo(Point other)
    {
        if (X != other.X) return X.CompareTo(other.X);
        return Y.CompareTo(other.Y);
    }

    public static bool operator ==(Point a, Point b) => a.X == b.X && a.Y == b.Y;
    public static bool operator !=(Point a, Point b) => !(a == b);

    public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);
    public static Point operator -(Point a, Point b) => new Point(a.X - b.X, a.Y - b.Y);

    public long Cross(Point p) => X * p.Y - Y * p.X;
    public long Cross(Point a, Point b) => (a - this).Cross(b - this);

    public override bool Equals(object? obj) => obj is Point p && this == p;
    public override int GetHashCode() => HashCode.Combine(X, Y);
}

class Program
{
    static List<Point> ConvexHull(List<Point> pts)
    {
        if (pts.Count <= 1) return pts;
        pts.Sort();

        Point[] h = new Point[pts.Count + 2];
        int s = 0, t = 0;

        for (int it = 0; it < 2; it++)
        {
            foreach (Point p in pts)
            {
                while (t >= s + 2 && h[t - 2].Cross(h[t - 1], p) <= 0)
                {
                    t--;
                }
                h[t++] = p;
            }
            s = --t;
            pts.Reverse();
        }

        int count = t - (t == 2 && h[0] == h[1] ? 1 : 0);
        List<Point> res = new List<Point>(count);
        for (int i = 0; i < count; i++)
        {
            res.Add(h[i]);
        }
        return res;
    }

    static long PolygonArea2(List<Point> v)
    {
        long a = v[^1].Cross(v[0]);
        for (int i = 0; i < v.Count - 1; i++)
        {
            a += v[i].Cross(v[i + 1]);
        }
        return a;
    }

    static void Main()
    {
        while (true)
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line)) break;

            long n = long.Parse(line.Trim());
            if (n == 0) break;

            List<Point> pts = new List<Point>();
            while (pts.Count < n)
            {
                string[] parts = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < parts.Length; i += 2)
                {
                    long x = long.Parse(parts[i]);
                    long y = long.Parse(parts[i + 1]);
                    pts.Add(new Point(x, y));
                }
            }

            var hull = ConvexHull(pts);
            long A2 = PolygonArea2(hull);

            double ans = Math.Abs(A2) / 2.0;
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Robot Protection");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}