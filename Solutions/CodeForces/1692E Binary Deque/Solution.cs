// Binary Deque
namespace CompetitiveProgramming.CodeForces.BinaryDeque;
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
            int[] ns = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = ns[0], s = ns[1];
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            int sum = 0;
            int ans = int.MaxValue;
            int l = 0, r = 0;
            
            while (r < n)
            {
                sum += v[r++];
                if (sum == s)
                {
                    ans = Math.Min(ans, n - (r - l));
                }
                while (sum > s)
                {
                    sum -= v[l++];
                }
            }
            
            Console.WriteLine(ans == int.MaxValue ? -1 : ans);
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
        StyleHelper.Title("Young Explorers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}