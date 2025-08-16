// MEXor Mixup
namespace CompetitiveProgramming.CodeForces.MEXorMixup;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long ComputeXOR(long n)
    {
        if (n % 4 == 0) return n;
        if (n % 4 == 1) return 1;
        if (n % 4 == 2) return n + 1;
        return 0;
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = input[0], b = input[1];
            long x = ComputeXOR(a - 1);
            long res = a + 2;
            if (x == b) res = a;
            else if ((x ^ b) != a) res = a + 1;
            Console.WriteLine(res);
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
        StyleHelper.Title("MEXor Mixup");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}