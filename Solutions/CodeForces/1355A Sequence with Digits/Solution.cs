// Sequence with Digits
namespace CompetitiveProgramming.CodeForces.SequencewithDigits;
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
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = input[0], k = input[1];
            k--;
            while (k-- > 0)
            {
                long temp = a;
                int mn = 9, mx = 0;
                while (temp > 0)
                {
                    int x = (int)(temp % 10);
                    mn = Math.Min(mn, x);
                    mx = Math.Max(mx, x);
                    temp /= 10;
                }
                if (mn * mx == 0) break;
                a += mn * mx;
            }
            Console.WriteLine(a);
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