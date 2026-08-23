// Curse the Darkness
namespace CompetitiveProgramming.Kattis.CursetheDarkness;
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
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string[] firstLine = Console.ReadLine().Split();
            double bx = double.Parse(firstLine[0]);
            double by = double.Parse(firstLine[1]);

            bool found = false;
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                string[] input = Console.ReadLine().Split();
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);

                double dx = bx - x;
                double dy = by - y;
                if (dx * dx + dy * dy <= 64)
                {
                    found = true;
                }
            }

            Console.WriteLine(found ? "light a candle" : "curse the darkness");
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
        StyleHelper.Title("Curse the Darkness");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}