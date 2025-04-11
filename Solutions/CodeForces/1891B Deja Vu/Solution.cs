// Deja Vu
namespace CompetitiveProgramming.CodeForces.DejaVu;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] nq = Console.ReadLine()!.Split();
            int n = int.Parse(nq[0]);
            int q = int.Parse(nq[1]);

            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[] smallerIdx = new int[35];
            for (int i = 0; i < 35; i++)
                smallerIdx[i] = int.MaxValue;

            for (int i = 0; i < q; i++)
            {
                if (smallerIdx[b[i]] == int.MaxValue)
                {
                    smallerIdx[b[i]] = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int firstIdx = int.MaxValue;
                for (int j = 1; j <= 30; j++)
                {
                    if (a[i] % (1 << j) == 0)
                    {
                        firstIdx = Math.Min(firstIdx, smallerIdx[j]);
                    }
                }

                while (firstIdx < q)
                {
                    a[i] += (1 << (b[firstIdx] - 1));
                    int x = b[firstIdx] - 1;
                    int xx = int.MaxValue;
                    while (x >= 0)
                    {
                        if (smallerIdx[x] != int.MaxValue && smallerIdx[x] > firstIdx)
                        {
                            xx = Math.Min(xx, smallerIdx[x]);
                        }
                        x--;
                    }
                    firstIdx = xx;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
                if (i < n - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Deja Vu");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}