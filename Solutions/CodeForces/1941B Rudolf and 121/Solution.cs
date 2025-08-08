// Rudolf and 121
namespace CompetitiveProgramming.CodeForces.Rudolfand121;
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
            bool valid = true;

            for (int p = 0; valid && p + 2 < n; p++)
            {
                if (a[p] < 0) { valid = false; }
                a[p + 1] -= 2 * a[p];
                a[p + 2] -= a[p];
            }

            valid = valid && a[n - 2] == 0 && a[n - 1] == 0;
            Console.WriteLine(valid ? "YES" : "NO");
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
        StyleHelper.Title("Rudolf and 121");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}