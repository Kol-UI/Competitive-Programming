// Forked
namespace CompetitiveProgramming.CodeForces.Forked;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            var ab = Console.ReadLine().Split().Select(long.Parse).ToList();
            long a = ab[0];
            long b = ab[1];
            
            var xk_yk = Console.ReadLine().Split().Select(long.Parse).ToList();
            long xk = xk_yk[0];
            long yk = xk_yk[1];
            
            var xq_yq = Console.ReadLine().Split().Select(long.Parse).ToList();
            long xq = xq_yq[0];
            long yq = xq_yq[1];
            
            var s = new HashSet<(long, long)>();
            s.Add((xk + a, yk + b));
            s.Add((xk - a, yk + b));
            s.Add((xk + a, yk - b));
            s.Add((xk - a, yk - b));
            s.Add((xk + b, yk + a));
            s.Add((xk - b, yk + a));
            s.Add((xk + b, yk - a));
            s.Add((xk - b, yk - a));
            
            var t_set = new HashSet<(long, long)>();
            t_set.Add((xq + a, yq + b));
            t_set.Add((xq - a, yq + b));
            t_set.Add((xq + a, yq - b));
            t_set.Add((xq - a, yq - b));
            t_set.Add((xq + b, yq + a));
            t_set.Add((xq - b, yq + a));
            t_set.Add((xq + b, yq - a));
            t_set.Add((xq - b, yq - a));

            int count = s.Intersect(t_set).Count();
            Console.WriteLine(count);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Forked");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}