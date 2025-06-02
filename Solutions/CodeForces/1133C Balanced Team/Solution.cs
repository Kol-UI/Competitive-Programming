// Balanced Team
namespace CompetitiveProgramming.CodeForces.BalancedTeam;
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
        int n = int.Parse(Console.ReadLine());
        int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(v);
        int i = 0, j = 0, mx = 0;
        while (j < n)
        {
            if (v[j] - v[i] <= 5)
            {
                mx = Math.Max(mx, j - i + 1);
                j++;
            }
            else
            {
                i++;
            }
        }
        Console.WriteLine(mx);
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
        StyleHelper.Title("Balanced Team");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}