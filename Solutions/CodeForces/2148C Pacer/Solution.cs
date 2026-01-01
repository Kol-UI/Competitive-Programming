// Pacer
namespace CompetitiveProgramming.CodeForces.Pacer;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            long wa = 0, wb = 0, cnt = 0;
            for (long p = 0; p < n; p++)
            {
                string[] ab = Console.ReadLine().Split();
                long a = long.Parse(ab[0]);
                long b = long.Parse(ab[1]);
                cnt += a - wa;
                cnt -= ((a - wa + 2) % 2 != (b - wb + 2) % 2) ? 1 : 0;
                wa = a;
                wb = b;
            }
            cnt += m - wa;
            Console.WriteLine(cnt);
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
        StyleHelper.Title("Pacer");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}