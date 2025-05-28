// XXXXX
namespace CompetitiveProgramming.CodeForces.XXXXX;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int tc = int.Parse(Console.ReadLine()!);
        while (tc-- > 0)
        {
            int[] nx = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int n = nx[0], x = nx[1];
            int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int ans = -1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += v[i];
                if (sum % x != 0)
                {
                    ans = i + 1;
                }
            }
            sum = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                sum += v[i];
                if (sum % x != 0)
                {
                    ans = Math.Max(ans, n - i);
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("XXXXX");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}