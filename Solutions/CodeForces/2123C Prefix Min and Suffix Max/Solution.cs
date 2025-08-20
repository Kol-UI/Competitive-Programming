// Prefix Min and Suffix Max
namespace CompetitiveProgramming.CodeForces.PrefixMinandSuffixMax;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            int[] b = new int[n];

            long x = 10000000;
            for (int p = 0; p < n; p++)
            {
                if (a[p] < x)
                {
                    b[p] = 1;
                    x = a[p];
                }
            }

            x = 0;
            for (int p = n - 1; p >= 0; p--)
            {
                if (a[p] > x)
                {
                    b[p] = 1;
                    x = a[p];
                }
            }

            for (int p = 0; p < n; p++)
            {
                Console.Write(b[p]);
            }
            Console.WriteLine();
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
        StyleHelper.Title("Prefix Min and Suffix Max");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}