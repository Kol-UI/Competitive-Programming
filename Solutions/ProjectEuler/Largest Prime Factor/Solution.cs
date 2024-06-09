// Largest Prime Factor

using System;

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.ProjectEuler.LargestPrimeFactor;

public class LargestPrimeFactor
{
    public static long FindLargestPrimeFactor(long n)
    {
        long largestPrime = 0;

        while (n % 2 == 0)
        {
            largestPrime = 2;
            n /= 2;
        }

        for (long i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                largestPrime = i;
                n /= i;
            }
        }

        if (n > 2)
        {
            largestPrime = n;
        }

        return largestPrime;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        long number = 600851475143;
        long result = LargestPrimeFactor.FindLargestPrimeFactor(number);
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(result, 6857)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Largest Prime Factor");
        ResultTester.CheckCurrentSolution(ProblemOrigin.ProjectEuler, ProblemCategory.OtherEuler, Test.TestCases());
    }
}