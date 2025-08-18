// Add and Divide
namespace CompetitiveProgramming.CodeForces.AddandDivide;
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
            long a = input[0], b = input[1];
            long res = 1 + a / b;

            for (long p = b; p <= b + 100; p++)
            {
                if (p == 1) continue;
                long div = 0, cur = a;
                while (cur > 0) { cur /= p; div++; }
                long cnt = (p - b) + div;
                res = Math.Min(res, cnt);
            }

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
        StyleHelper.Title("Add and Divide");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}