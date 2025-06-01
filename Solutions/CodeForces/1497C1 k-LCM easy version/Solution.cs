// k-LCM (easy version)
namespace CompetitiveProgramming.CodeForces.kLCMeasyversion;
using CompetitiveProgramming;
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
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], k = input[1];
            int a, b, c;
            if ((n & 1) == 1)
            {
                a = n / 2;
                b = a;
                c = 1;
            }
            else
            {
                if (((n / 2) & 1) == 1)
                {
                    a = (n / 2) - 1;
                    b = a;
                    c = n - 2 * b;
                }
                else
                {
                    a = n / 2;
                    b = n / 4;
                    c = b;
                }
            }
            Console.WriteLine($"{a} {b} {c}");
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
        StyleHelper.Title("Sequence with Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}