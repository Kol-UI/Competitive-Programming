// Sum of Digits
namespace CompetitiveProgramming.CodeForces.SumofDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long SumOfDigits(long x)
    {
        long output = 0;
        while (x > 0)
        {
            output += x % 10;
            x /= 10;
        }
        return output;
    }

    //static void Main()
    public static void MainSolution()
    {
        string input = Console.ReadLine();
        if (input.Length == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            long current = 0;
            long times = 1;
            foreach (char c in input)
            {
                current += c - '0';
            }
            while (current > 9)
            {
                current = SumOfDigits(current);
                times++;
            }
            Console.WriteLine(times);
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
        StyleHelper.Title("Sum of Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}