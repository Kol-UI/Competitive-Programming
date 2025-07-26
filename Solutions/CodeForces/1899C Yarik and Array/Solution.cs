// Yarik and Array
namespace CompetitiveProgramming.CodeForces.YarikandArray;
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
            
            int prev = 0, cs = 0, mxs = -1007;
            for (int p = 0; p < n; p++)
            {
                int x = nums[p];
                if ((prev + x) % 2 == 0 || cs < 0) cs = 0;
                cs += x;
                mxs = Math.Max(mxs, cs);
                prev = x % 2;
            }
            
            Console.WriteLine(mxs);
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
        StyleHelper.Title("Yarik and Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}