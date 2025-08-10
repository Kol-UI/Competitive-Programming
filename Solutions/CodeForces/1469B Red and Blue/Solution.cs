// Red and Blue
namespace CompetitiveProgramming.CodeForces.RedandBlue;
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
            long sr = 0, msr = 0;
            long[] red = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in red)
            {
                sr += x;
                msr = Math.Max(msr, sr);
            }

            int m = int.Parse(Console.ReadLine());
            long sb = 0, msb = 0;
            long[] blue = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in blue)
            {
                sb += x;
                msb = Math.Max(msb, sb);
            }

            Console.WriteLine(msr + msb);
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
        StyleHelper.Title("Red and Blue");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}