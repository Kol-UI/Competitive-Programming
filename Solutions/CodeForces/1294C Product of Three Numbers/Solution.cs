// Product of Three Numbers
namespace CompetitiveProgramming.CodeForces.ProductofThreeNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                int first = n / i;
                for (int j = i + 1; j * j <= first; j++)
                {
                    if (first % j == 0 && first / j != j)
                    {
                        Console.WriteLine("YES");
                        Console.WriteLine($"{i} {j} {first / j}");
                        return;
                    }
                }
            }
        }
        Console.WriteLine("NO");
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            Solve();
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
        StyleHelper.Title("Product of Three Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
	}
}