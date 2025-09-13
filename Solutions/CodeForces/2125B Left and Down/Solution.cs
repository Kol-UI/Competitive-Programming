// Left and Down
namespace CompetitiveProgramming.CodeForces.LeftandDown;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long Gcd(long a, long b) => a == 0 ? b : Gcd(b % a, a);

    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long k = long.Parse(input[2]);
            long g = Gcd(a, b);
            int res = 2 - (a / g + b / g <= 2 * k && a / g <= k && b / g <= k ? 1 : 0);
            Console.WriteLine(res);
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
        StyleHelper.Title("Left and Down");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}