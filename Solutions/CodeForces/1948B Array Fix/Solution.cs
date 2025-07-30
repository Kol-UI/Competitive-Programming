// Array Fix
namespace CompetitiveProgramming.CodeForces.ArrayFix;
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
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int prev = -1;
            bool res = true;

            foreach (int x in nums)
            {
                int d = x / 10;
                int m = x % 10;

                if (prev <= d && d <= m)
                {
                    prev = m;
                }
                else if (prev <= x)
                {
                    prev = x;
                }
                else
                {
                    res = false;
                }
            }

            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Array Fix");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}