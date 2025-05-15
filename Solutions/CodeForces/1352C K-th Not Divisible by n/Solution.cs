// K-th Not Divisible by n
namespace CompetitiveProgramming.CodeForces.KthNotDivisiblebyn;
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
            string[] input = Console.ReadLine()!.Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);

            if (k < n)
            {
                Console.WriteLine(k);
            }
            else
            {
                long ans = k + (k - 1) / (n - 1);
                Console.WriteLine(ans);
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("K-th Not Divisible by n");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}