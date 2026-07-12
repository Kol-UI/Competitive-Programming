// Island Hopping
namespace CompetitiveProgramming.Kattis.IslandHopping;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    struct Point
    {
        public double x, y;
    }

    struct Edge
    {
        public double dist;
        public int n1, n2;
    }

    static double Dist(Point p1, Point p2)
    {
        double dx = p1.x - p2.x;
        double dy = p1.y - p2.y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    static int Find(List<int> d, int a)
    {
        if (d[a] == -1) return a;
        d[a] = Find(d, d[a]);
        return d[a];
    }

    static void Join(List<int> d, int a, int b)
    {
        a = Find(d, a);
        b = Find(d, b);
        if (a == b) return;
        d[a] = b;
    }

    static void Main()
    {
        int cases = int.Parse(Console.ReadLine());

        while (cases-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> v = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Point p;
                p.x = double.Parse(input[0]);
                p.y = double.Parse(input[1]);
                v.Add(p);
            }

            List<Edge> e = new List<Edge>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    Edge edge;
                    edge.dist = Dist(v[i], v[j]);
                    edge.n1 = i;
                    edge.n2 = j;
                    e.Add(edge);
                }
            }

            e.Sort((a, b) => a.dist.CompareTo(b.dist));

            List<int> d = new List<int>();
            for (int i = 0; i < n; i++) d.Add(-1);

            double total = 0;
            foreach (Edge edge in e)
            {
                if (Find(d, edge.n1) != Find(d, edge.n2))
                {
                    Join(d, edge.n1, edge.n2);
                    total += edge.dist;
                }
            }

            Console.WriteLine($"{total:F4}");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Island Hopping");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}