// Equal Rectangles
namespace CompetitiveProgramming.CodeForces.EqualRectangles;
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
        long q = long.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<long> a = new List<long>();
            for (long p = 0; p < 4 * n; p++)
            {
                a.Add(long.Parse(input[p]));
            }
            a.Sort();
            
            long left = 0;
            long right = 4 * n - 1;
            long area = -1;
            bool possible = true;
            
            while (possible && left < right)
            {
                if (a[(int)left] != a[(int)left + 1]) possible = false;
                if (a[(int)right] != a[(int)right - 1]) possible = false;
                
                long tst = a[(int)left] * a[(int)right];
                if (area < 0) area = tst;
                if (tst != area) possible = false;
                
                left += 2;
                right -= 2;
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
        StyleHelper.Title("Equal Rectangles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}