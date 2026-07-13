// Contest Struggles
namespace CompetitiveProgramming.Kattis.ContestStruggles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);

        string[] secondLine = Console.ReadLine().Split();
        int d = int.Parse(secondLine[0]);
        int s = int.Parse(secondLine[1]);

        double ans = (double)(d * n - s * k) / (n - k);

        if (ans < 0 || ans > 100)
            Console.WriteLine("impossible");
        else
            Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Contest Struggles");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}