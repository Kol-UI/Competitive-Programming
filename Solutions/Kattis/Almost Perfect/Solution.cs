// Almost Perfect
namespace CompetitiveProgramming.Kattis.AlmostPerfect;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static long SumDivisors(long n)
    {
        long sum = 0;
        long sqrtN = (long)Math.Sqrt(n);

        for (int i = 1; i <= sqrtN; i++)
        {
            if (n % i == 0)
            {
                if (i == sqrtN && sqrtN * sqrtN == n)
                {
                    sum += i;
                }
                else
                {
                    sum += i;
                    sum += n / i;
                }
            }
        }

        sum -= n;
        return sum;
    }

    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            long n = long.Parse(line);
            long d = SumDivisors(n);

            if (n == d)
            {
                Console.WriteLine($"{n} perfect");
            }
            else if (Math.Abs(n - d) <= 2)
            {
                Console.WriteLine($"{n} almost perfect");
            }
            else
            {
                Console.WriteLine($"{n} not perfect");
            }
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Almost Perfect");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}