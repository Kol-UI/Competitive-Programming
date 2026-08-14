// Equal XOR
namespace CompetitiveProgramming.CodeForces.EqualXOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);

            string[] input = Console.ReadLine().Split();
            long[] v = new long[2 * n];
            long[] w = new long[n + 1];

            for (long p = 0; p < 2 * n; p++)
            {
                v[p] = long.Parse(input[p]);
                if (p >= n) continue;
                w[v[p]]++;
            }

            List<long> a = new List<long>();
            List<long> b = new List<long>();

            for (long p = 1; p <= n; p++)
            {
                if (w[p] == 2 && a.Count < 2 * k)
                {
                    a.Add(p);
                    a.Add(p);
                }
                else if (w[p] == 0 && b.Count < 2 * k)
                {
                    b.Add(p);
                    b.Add(p);
                }
            }

            while (a.Count < b.Count) b.RemoveAt(b.Count - 1);
            while (b.Count < a.Count) a.RemoveAt(a.Count - 1);

            for (long p = 1; a.Count < 2 * k && p <= n; p++)
            {
                if (w[p] % 2 == 1)
                {
                    a.Add(p);
                    b.Add(p);
                }
            }

            for (long p = 0; p < a.Count; p++)
                Console.Write($"{a[(int)p]} ");
            Console.WriteLine();

            for (long p = 0; p < b.Count; p++)
                Console.Write($"{b[(int)p]} ");
            Console.WriteLine();
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
        StyleHelper.Title("Equal XOR");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}