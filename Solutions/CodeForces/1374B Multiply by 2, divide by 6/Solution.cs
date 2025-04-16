// Multiply by 2, divide by 6
namespace CompetitiveProgramming.CodeForces.Multiplyby2divideby6;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            long N = long.Parse(Console.ReadLine()!);
            long num2inN = 0, num3inN = 0;

            while (N % 2 == 0)
            {
                num2inN++;
                N /= 2;
            }

            while (N % 3 == 0)
            {
                num3inN++;
                N /= 3;
            }

            if (N != 1 || num2inN > num3inN)
                Console.WriteLine(-1);
            else
                Console.WriteLine((num3inN - num2inN) + num3inN);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Multiply by 2, divide by 6");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}