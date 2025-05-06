// Sum of Odd Integers
namespace CompetitiveProgramming.CodeForces.SumofOddIntegers;
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
            
            Console.WriteLine((n >= k * k) && (n % 2 == k % 2) ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Odd Integers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}