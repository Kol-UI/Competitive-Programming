// Euclidean TSP
namespace CompetitiveProgramming.Kattis.EuclideanTSP;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Globalization;

class Program
{
    static double n, p, s, v;

    static double Check(double c)
    {
        return n * Math.Pow(Math.Log(n) / Math.Log(2), c * Math.Sqrt(2)) / (p * Math.Pow(10, 9)) + (s * (1 + 1 / c)) / v;
    }

    static void Main()
    {
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        n = double.Parse(input[0], CultureInfo.InvariantCulture);
        p = double.Parse(input[1], CultureInfo.InvariantCulture);
        s = double.Parse(input[2], CultureInfo.InvariantCulture);
        v = double.Parse(input[3], CultureInfo.InvariantCulture);

        double ACC = 0.0000001;
        double lo = 0.00001;
        double hi = 100;

        while (hi - lo > ACC)
        {
            double mid1 = (hi + lo) / 2;
            double mid2 = mid1 + ACC;
            double a = Check(mid1);
            double b = Check(mid2);

            if (a > b)
            {
                lo = mid1;
            }
            else
            {
                hi = mid1;
            }
        }

        double ans = (lo + hi) / 2;
        Console.WriteLine($"{Check(ans)} {ans}");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Euclidean TSP");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}