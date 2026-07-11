// Billiard
namespace CompetitiveProgramming.Kattis.Billiard;
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
            string[] input = line.Split();
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double s = double.Parse(input[2]);
            double m = double.Parse(input[3]);
            double n = double.Parse(input[4]);
            
            if (a == 0 && b == 0 && s == 0 && m == 0 && n == 0)
                break;
            
            double xDist = a * m;
            double yDist = b * n;
            
            double angle = Math.Atan(yDist / xDist) * 180 / Math.PI;
            double dist = Math.Sqrt(xDist * xDist + yDist * yDist);
            
            Console.WriteLine($"{angle:F2} {dist / s:F2}");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Billiard");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}