// Recovering a Small String
namespace CompetitiveProgramming.CodeForces.RecoveringaSmallString;
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
        for (int i = 1; i <= 26; i++)
        {
            for (int j = 1; j <= 26; j++)
            {
                for (int k = 1; k <= 26; k++)
                {
                    if (i + j + k == n)
                    {
                        Console.WriteLine($"{(char)('a' + i - 1)}{(char)('a' + j - 1)}{(char)('a' + k - 1)}");
                        return;
                    }
                }
            }
        }
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
        StyleHelper.Title("Recovering a Small String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
	}
}