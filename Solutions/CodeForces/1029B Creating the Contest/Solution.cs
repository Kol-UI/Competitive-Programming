// Creating the Contest
namespace CompetitiveProgramming.CodeForces.CreatingtheContest;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine()!);
        long[] a = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

        long cnt = 1, mx = 1;
        for (long p = 1; p < n; p++)
        {
            cnt = (a[p - 1] * 2 >= a[p]) ? (cnt + 1) : 1;
            mx = (mx > cnt) ? mx : cnt;
        }

        Console.WriteLine(mx);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Creating the Contest");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}