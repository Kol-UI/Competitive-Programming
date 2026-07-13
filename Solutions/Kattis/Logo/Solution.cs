// Logo
namespace CompetitiveProgramming.Kattis.Logo;
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
            int n = int.Parse(Console.ReadLine());
            double posx = 0;
            double posy = 0;
            double curd = 0;

            for (int j = 0; j < n; j++)
            {
                string[] input = Console.ReadLine().Split();
                string cmd = input[0];
                int d = int.Parse(input[1]);

                double rad = curd * Math.PI / 180.0;

                if (cmd == "fd")
                {
                    posx += d * Math.Cos(rad);
                    posy += d * Math.Sin(rad);
                }
                else if (cmd == "lt")
                {
                    curd += d;
                    curd %= 360;
                }
                else if (cmd == "rt")
                {
                    curd -= d;
                    curd %= 360;
                    if (curd < 0) curd += 360;
                }
                else if (cmd == "bk")
                {
                    posx -= d * Math.Cos(rad);
                    posy -= d * Math.Sin(rad);
                }
            }

            double dist = Math.Sqrt(posx * posx + posy * posy);
            Console.WriteLine(Math.Round(dist));
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
        StyleHelper.Title("Logo");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}