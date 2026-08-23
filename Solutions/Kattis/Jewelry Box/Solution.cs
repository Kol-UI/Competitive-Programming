// Jewelry Box
namespace CompetitiveProgramming.Kattis.JewelryBox;
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

            if (d1 > d2)
            {
                double temp = d1;
                d1 = d2;
                d2 = temp;
            }

            double lo = 0;
            double hi = d1 / 2;

            while (hi - lo > 0.0000001)
            {
                double mid1 = (hi - lo) * (1.0 / 3) + lo;
                double mid2 = (hi - lo) * (2.0 / 3) + lo;
                double ans1 = mid1 * (d1 - 2 * mid1) * (d2 - 2 * mid1);
                double ans2 = mid2 * (d1 - 2 * mid2) * (d2 - 2 * mid2);

                if (ans1 > ans2)
                    hi = mid2;
                else
                    lo = mid1;
            }

            Console.WriteLine($"{lo * (d1 - 2 * lo) * (d2 - 2 * lo):F9}");
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
        StyleHelper.Title("Jewelry Box");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}