// Even Fibonacci Numbers


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.ProjectEuler.EvenFibonacciNumbers;

class Program
{
    public static int Solution()
    {
        int limit = 4000000;
        int result = SumEvenFibonacci(limit);
        return result;
    }

    private static int SumEvenFibonacci(int limit)
    {
        int sum = 0;
        int a = 1;
        int b = 2;

        while (b < limit)
        {
            if (b % 2 == 0)
            {
                sum += b;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Program.Solution(), Program.Solution())
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Even Fibonacci Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.ProjectEuler, ProblemCategory.OtherEuler, Test.TestCases());
    }
}