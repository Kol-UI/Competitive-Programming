// Dora and Search
namespace CompetitiveProgramming.CodeForces.DoraandSearch;
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
            string[] input = Console.ReadLine().Split();
            long[] a = new long[n];
            for (long p = 0; p < n; p++)
            {
                a[p] = long.Parse(input[p]);
            }
            
            long left = 0, right = n - 1;
            long mn = 1, mx = n;
            
            while (left < right)
            {
                if (a[left] == mn) { left++; mn++; }
                else if (a[right] == mn) { right--; mn++; }
                else if (a[left] == mx) { left++; mx--; }
                else if (a[right] == mx) { right--; mx--; }
                else { break; }
            }
            
            if (left < right)
            {
                Console.WriteLine($"{left + 1} {right + 1}");
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
        StyleHelper.Title("Dora and Search");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}