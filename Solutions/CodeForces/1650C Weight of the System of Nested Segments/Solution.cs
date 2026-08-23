// Weight of the System of Nested Segments
namespace CompetitiveProgramming.CodeForces.WeightoftheSystemofNestedSegments;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine() ?? "0");
        while (t-- > 0)
        {
            Console.ReadLine();
            long[] nm = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long n = nm[0];
            long m = nm[1];

            var v = new (long weight, long x, long id)[m];
            for (long p = 0; p < m; p++)
            {
                long[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                v[p] = (weight: line[1], x: line[0], id: p + 1);
            }

            Array.Sort(v, (a, b) => a.weight.CompareTo(b.weight));

            var z = new (long x, long id)[2 * n];
            long wsum = 0;
            for (int p = 0; p < 2 * n; p++)
            {
                wsum += v[p].weight;
                z[p] = (v[p].x, v[p].id);
            }

            Console.WriteLine(wsum);
            Array.Sort(z, (a, b) => a.x.CompareTo(b.x));

            for (int p = 0; p < n; p++)
            {
                Console.WriteLine($"{z[p].id} {z[2 * n - 1 - p].id}");
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Weight of the System of Nested Segments");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}