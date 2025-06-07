// Maximum Product
namespace CompetitiveProgramming.CodeForces.MaximumProduct;
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
            long[] v = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Array.Sort(v);
            long ans = 1;
            for (int x = n - 1; x >= (n - 5); x--)
            {
                ans *= v[x];
            }
            ans = Math.Max(ans, (v[0] * v[1] * v[n - 1] * v[n - 2] * v[n - 3]));
            ans = Math.Max(ans, (v[0] * v[1] * v[2] * v[3] * v[n - 1]));
            Console.WriteLine(ans);
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
        StyleHelper.Title("Maximum Product");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}