// Swap Columns and Find a Path
namespace CompetitiveProgramming.CodeForces.SwapColumnsandFindaPath;
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
            string[] aInput = Console.ReadLine().Split();
            string[] bInput = Console.ReadLine().Split();
            
            long[] a = new long[n];
            long[] b = new long[n];
            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(aInput[p]);
                b[p] = long.Parse(bInput[p]);
            }
            
            long add = -1000000000;
            long total = 0;
            
            for (long p = 0; p < n; p++)
            {
                total += (a[p] > b[p]) ? a[p] : b[p];
                long second = (a[p] < b[p]) ? a[p] : b[p];
                if (second > add) add = second;
            }
            
            total += add;
            Console.WriteLine(total);
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
        StyleHelper.Title("Swap Columns and Find a Path");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}