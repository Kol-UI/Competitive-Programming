// 2061C1 Skibidus and Fanum Tax easy version
namespace CompetitiveProgramming.CodeForces.SkibidusandFanumTaxeasyversion;
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
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0], m = nm[1];
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int b = int.Parse(Console.ReadLine());

            bool res = true;
            a[0] = Math.Min(a[0], b - a[0]);
            for (int p = 1; res && p < n; p++)
            {
                if (a[p - 1] <= a[p] && a[p - 1] <= b - a[p])
                    a[p] = Math.Min(a[p], b - a[p]);
                else if (a[p - 1] <= a[p]) { }
                else if (a[p - 1] <= b - a[p])
                    a[p] = b - a[p];
                else
                    res = false;
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
        StyleHelper.Title("Skibidus and Fanum Tax easy version");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}