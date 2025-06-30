// Buying Shovels
namespace CompetitiveProgramming.CodeForces.BuyingShovels;
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

            if (n <= k)
            {
                Console.WriteLine(1);
                continue;
            }

            int ans = n;
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (n / i <= k)
                        ans = Math.Min(ans, n / (n / i));
                    if (i <= k)
                        ans = Math.Min(ans, n / i);
                }
            }
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
        StyleHelper.Title("Buying Shovels");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
	}
}