// AND 0, Sum Big
namespace CompetitiveProgramming.CodeForces.AND0SumBig;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    const long mod = 1000000007;

    static long Exp(long n, long k)
    {
        long ans = 1;
        while (k > 0)
        {
            if ((k & 1) == 1)
                ans = (ans % mod * n % mod) % mod;
            k >>= 1;
            n = (n % mod * n % mod) % mod;
        }
        return ans;
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0], k = input[1];
            Console.WriteLine(Exp(n, k));
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
        StyleHelper.Title("AND 0, Sum Big");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}