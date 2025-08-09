// Payment Without Change
namespace CompetitiveProgramming.CodeForces.PaymentWithoutChange;
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
        int q = int.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = input[0], b = input[1], n = input[2], s = input[3];
            bool ans = (n * a + b >= s) && (b >= s % n);
            Console.WriteLine(ans ? "YES" : "NO");
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
        StyleHelper.Title("Payment Without Change");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}