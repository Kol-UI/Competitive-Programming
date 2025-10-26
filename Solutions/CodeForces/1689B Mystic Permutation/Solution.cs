// Mystic Permutation
namespace CompetitiveProgramming.CodeForces.MysticPermutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] v = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            if (n <= 1)
            {
                Console.WriteLine("-1");
                continue;
            }
            long[] b = new long[n];
            long wait = -1;
            for (long p = 0; p < n; p++)
            {
                if (wait > 0)
                {
                    b[p] = wait;
                    wait = -1;
                }
                else if (v[p] == p + 1)
                {
                    b[p] = p + 2;
                    wait = p + 1;
                }
                else
                {
                    b[p] = p + 1;
                }
            }
            if (wait > 0)
            {
                b[n - 1] = b[n - 2];
                b[n - 2] = wait;
            }
            foreach (long num in b) Console.Write(num + " ");
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
        StyleHelper.Title("Mystic Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}