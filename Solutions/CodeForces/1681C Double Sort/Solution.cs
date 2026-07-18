// Double Sort
namespace CompetitiveProgramming.CodeForces.DoubleSort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static bool IsSorted(long[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i])
                return false;
        }
        return true;
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] aInput = Console.ReadLine().Split();
            string[] bInput = Console.ReadLine().Split();

            long[] a = new long[n];
            long[] b = new long[n];
            List<(int, int)> v = new List<(int, int)>();

            for (long p = 0; p < n; p++)
                a[p] = long.Parse(aInput[p]);

            for (long p = 0; p < n; p++)
                b[p] = long.Parse(bInput[p]);

            for (long p = 0; p < n; p++)
            {
                for (long q = 0; q < n - 1; q++)
                {
                    if (a[q] > a[q + 1] || b[q] > b[q + 1])
                    {
                        long tempA = a[q];
                        a[q] = a[q + 1];
                        a[q + 1] = tempA;

                        long tempB = b[q];
                        b[q] = b[q + 1];
                        b[q + 1] = tempB;

                        v.Add(((int)q, (int)q + 1));
                    }
                }
            }

            if (IsSorted(a) && IsSorted(b))
            {
                Console.WriteLine(v.Count);
                foreach (var (first, second) in v)
                {
                    Console.WriteLine($"{first + 1} {second + 1}");
                }
            }
            else
            {
                Console.WriteLine("-1");
            }
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
        StyleHelper.Title("Double Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}