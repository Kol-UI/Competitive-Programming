// Cut Ribbon
namespace CompetitiveProgramming.CodeForces.CutRibbon;
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
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int a = int.Parse(input[1]);
        int b = int.Parse(input[2]);
        int c = int.Parse(input[3]);
        int ans = 0;

        for (int x = 0; x <= n; x++)
        {
            for (int y = 0; y <= n; y++)
            {
                int cz = n - (a * x + b * y);
                if (cz < 0) break;
                double z = cz / (double)c;
                if (z == (int)z)
                {
                    ans = Math.Max(ans, x + y + (int)z);
                }
            }
        }

        Console.WriteLine(ans);
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
        StyleHelper.Title("Cut Ribbon");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
	}
}