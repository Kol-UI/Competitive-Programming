// Splitting Items
namespace CompetitiveProgramming.CodeForces.SplittingItems;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] nk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nk[0], k = nk[1];
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            Array.Sort(a);
            Array.Reverse(a);
            
            long A = 0, B = 0;
            for (int p = 0; p < n; p++)
            {
                if (p % 2 == 1)
                {
                    long diff = Math.Min(a[p - 1] - a[p], k);
                    k -= diff;
                    B += a[p] + diff;
                }
                else
                {
                    A += a[p];
                }
            }
            
            Console.WriteLine(A - B);
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
        StyleHelper.Title("Splitting Items");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}