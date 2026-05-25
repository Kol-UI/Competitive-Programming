// Bus
namespace CompetitiveProgramming.Kattis.Bus;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            double ans = 0;

            for (int j = 0; j < temp; j++)
            {
                ans += 0.5;
                ans *= 2;
            }

            Console.WriteLine((long)ans);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bus");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}