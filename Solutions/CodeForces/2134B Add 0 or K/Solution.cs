// Add 0 or K
namespace CompetitiveProgramming.CodeForces.AddZeroorK;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);
            
            string[] secondLine = Console.ReadLine().Split();
            long[] a = new long[n];
            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(secondLine[p]);
                a[p] += (a[p] % (k + 1)) * k;
            }
            
            for (long p = 0; p < n; p++)
            {
                Console.Write($"{a[p]} ");
            }
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
        StyleHelper.Title("Add 0 or K");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}