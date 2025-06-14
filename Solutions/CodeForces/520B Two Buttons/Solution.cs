// Two Buttons
namespace CompetitiveProgramming.CodeForces.TwoButtons;
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
        int m = int.Parse(input[1]);
        int cnt = 0;

        if (m <= n)
        {
            Console.WriteLine(n - m);
        }
        else
        {
            while (m > n)
            {
                if ((m & 1) == 1)
                {
                    cnt++;
                    m++;
                }
                m /= 2;
                cnt++;
            }
            Console.WriteLine(cnt + (n - m));
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
        StyleHelper.Title("Two Buttons");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1400);
	}
}