// Prefix Sum Primes
namespace CompetitiveProgramming.CodeForces.PrefixSumPrimes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        long ones = 0, twos = 0;

        for (long p = 0; p < n; p++)
        {
            long x = long.Parse(inputs[p]);
            if (x == 1) ones++;
            if (x == 2) twos++;
        }

        if (twos > 0)
        {
            Console.Write("2 ");
            twos--;
        }
        if (ones > 0)
        {
            Console.Write("1 ");
            ones--;
        }
        while (twos-- > 0)
        {
            Console.Write("2 ");
        }
        while (ones-- > 0)
        {
            Console.Write("1 ");
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Prefix Sum Primes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}