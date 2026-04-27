// Plus Minus Permutation
namespace CompetitiveProgramming.CodeForces.PlusMinusPermutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long x = long.Parse(input[1]);
            long y = long.Parse(input[2]);
            
            long lcm = (x / Gcd(x, y)) * y;
            long nx = (n / lcm) * (lcm / x - 1) + (n % lcm) / x;
            long ny = (n / lcm) * (lcm / y - 1) + (n % lcm) / y;
            
            long plus = nx * (2 * n - nx + 1) / 2;
            long minus = ny * (ny + 1) / 2;
            
            Console.WriteLine(plus - minus);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Plus Minus Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}