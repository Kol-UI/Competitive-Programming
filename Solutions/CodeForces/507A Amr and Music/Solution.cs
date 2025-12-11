// Amr and Music
namespace CompetitiveProgramming.CodeForces.AmrandMusic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var line = Console.ReadLine().Split(' ');
        long a = long.Parse(line[0]);
        long b = long.Parse(line[1]);

        var c = new List<(long val, long id)>();
        var input = Console.ReadLine().Split(' ');

        for (int d = 0; d < a; d++)
        {
            long e = long.Parse(input[d]);
            c.Add((e, d + 1));
        }

        c.Sort((x, y) => x.val.CompareTo(y.val));

        var f = new List<long>();
        long g = b;

        foreach (var h in c)
        {
            if (h.val > g)
            {
                break;
            }

            g -= h.val;
            f.Add(h.id);
        }

        Console.WriteLine(f.Count);
        Console.WriteLine(string.Join(" ", f));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Amr and Music");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}