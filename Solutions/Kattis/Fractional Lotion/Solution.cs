// Fractional Lotion
namespace CompetitiveProgramming.Kattis.FractionalLotion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            long n = long.Parse(line.Substring(2));

            long cnt = 0;
            for (long x = 2 * n; x > n; x--)
            {
                if ((n * x) % (x - n) == 0)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fractional Lotion");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}