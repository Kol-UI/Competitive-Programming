// Array and Permutation
namespace CompetitiveProgramming.CodeForces.ArrayandPermutation;
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
            string[] vInput = Console.ReadLine().Split();
            string[] zInput = Console.ReadLine().Split();

            long[] v = new long[n + 1];
            long[] z = new long[n + 1];
            long[] where = new long[n + 1];

            for (long p = 1; p <= n; p++)
            {
                v[p] = long.Parse(vInput[p - 1]);
                where[v[p]] = p;
            }

            for (long p = 1; p <= n; p++)
            {
                z[p] = long.Parse(zInput[p - 1]);
            }

            bool possible = true;
            for (long p = 1; p <= n; p++)
            {
                if (where[z[p - 1]] > where[z[p]])
                {
                    possible = false;
                    break;
                }
            }

            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Array and Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
