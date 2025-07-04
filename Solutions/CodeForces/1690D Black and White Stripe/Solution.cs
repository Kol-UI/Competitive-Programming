// Black and White Stripe
namespace CompetitiveProgramming.CodeForces.BlackandWhiteStripe;
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
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            string str = Console.ReadLine();
            int[] psum = new int[n + 1];
            for (int i = 0; i < n; i++)
                psum[i + 1] = psum[i] + (str[i] == 'W' ? 1 : 0);
            
            int ans = k;
            for (int i = 0; i <= n - k; i++)
                ans = Math.Min(ans, psum[i + k] - psum[i]);
            
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
        StyleHelper.Title("Black and White Stripe");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}