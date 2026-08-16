// Cardboard Container
namespace CompetitiveProgramming.Kattis.CardboardContainer;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long v = long.Parse(Console.ReadLine());
        long ans = long.MaxValue;

        for (long l = 1; l <= 1000; l++)
        {
            for (long w = 1; w <= 1000; w++)
            {
                if (v % (l * w) != 0) continue;
                long h = v / (l * w);

                long ar = l * w * 2 + l * h * 2 + w * h * 2;
                if (ar < ans) ans = ar;
            }
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cardboard Container");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}