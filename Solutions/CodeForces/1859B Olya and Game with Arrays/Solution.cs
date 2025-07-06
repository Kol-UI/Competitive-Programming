// Olya and Game with Arrays
namespace CompetitiveProgramming.CodeForces.OlyaandGamewithArrays;
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
            int n = int.Parse(Console.ReadLine());
            long mn1 = int.MaxValue, mn = int.MaxValue;
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                long[] v = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                Array.Sort(v);
                sum += v[1];
                if (v[1] <= mn1)
                {
                    mn1 = v[1];
                }
                mn = Math.Min(mn, v[0]);
            }
            Console.WriteLine(sum - mn1 + Math.Min(mn1, mn));
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
        StyleHelper.Title("Olya and Game with Arrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}