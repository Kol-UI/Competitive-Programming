// Vlad and a Sum of Sum of Digits
namespace CompetitiveProgramming.CodeForces.VladandaSumofSumofDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static long[] ans = new long[200010];

    static long Dig(long x)
    {
        long s = 0;
        while(x > 0)
        {
            s += x % 10;
            x /= 10;
        }
        return s;
    }

    static void Pre()
    {
        for(int i = 1; i < 200010; i++)
        {
            ans[i] = ans[i-1] + Dig(i);
        }
    }

    //static void Main()
    public static void MainSolution()
    {
        Pre();
        int t = int.Parse(Console.ReadLine()!);
        while(t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine(ans[n]);
        }
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Vlad and a Sum of Sum of Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}