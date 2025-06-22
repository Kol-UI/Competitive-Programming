// Boredom
namespace CompetitiveProgramming.CodeForces.Boredom;
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
        const int m = 100010;
        int n = int.Parse(Console.ReadLine());
        long[] freq = new long[m];
        long[] dp = new long[m];
        
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(input[i]);
            freq[temp]++;
        }
        
        dp[0] = 0;
        dp[1] = freq[1];
        
        for (int i = 2; i < m; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + i * freq[i]);
        }
        
        Console.WriteLine(dp[m - 1]);
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
        StyleHelper.Title("Boredom");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1500);
	}
}