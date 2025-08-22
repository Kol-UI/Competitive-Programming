// Make Product Equal One
namespace CompetitiveProgramming.CodeForces.MakeProductEqualOne;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long n = long.Parse(Console.ReadLine());
        long neg = 0, cnt = 0;
        bool zero = false;
        string[] input = Console.ReadLine().Split();
        for (long p = 0; p < n; p++)
        {
            long a = long.Parse(input[p]);
            if (a == 0) { cnt++; zero = true; }
            else if (a > 0) cnt += a - 1;
            else if (a < 0) { cnt += -a - 1; neg++; }
        }
        cnt += 2 * (!zero ? 1 : 0) * (neg % 2);
        Console.WriteLine(cnt);
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
        StyleHelper.Title("Make Product Equal One");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}