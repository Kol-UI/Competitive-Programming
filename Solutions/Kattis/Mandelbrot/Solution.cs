// Mandelbrot
namespace CompetitiveProgramming.Kattis.Mandelbrot;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int tc = 1;
        string line;

        while ((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split();
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            int r = int.Parse(input[2]);

            double zr = 0, zi = 0;
            bool div = false;

            for (int i = 0; i <= r; i++)
            {
                if (zr * zr + zi * zi > 4.0)
                {
                    div = true;
                    break;
                }

                double newZr = zr * zr - zi * zi + x;
                double newZi = 2 * zr * zi + y;
                zr = newZr;
                zi = newZi;
            }

            Console.WriteLine($"Case {tc}: {(div ? "OUT" : "IN")}");
            tc++;
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mandelbrot");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}