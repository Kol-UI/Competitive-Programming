// Heart Rate
namespace CompetitiveProgramming.Kattis.HeartRate;
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
        int cases = int.Parse(Console.ReadLine());

        while (cases-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            double d1 = double.Parse(input[0]);
            double d2 = double.Parse(input[1]);

            double ans = 60.0 * (d1 / d2);
            double var = 60.0 / d2;

            Console.WriteLine($"{ans - var:F4} {ans:F4} {ans + var:F4}");
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
        StyleHelper.Title("Heart Rate");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}