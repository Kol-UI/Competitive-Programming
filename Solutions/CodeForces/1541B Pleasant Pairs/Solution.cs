// Pleasant Pairs
namespace CompetitiveProgramming.CodeForces.PleasantPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = (int)(a[i] - (i + 1)); j <= n; j += a[i])
                {
                    if (j > 0 && j < i + 1 && a[i] * a[j - 1] == i + 1 + j)
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Pleasant Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}