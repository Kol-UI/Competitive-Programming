// Estimating the Area of a Circle
namespace CompetitiveProgramming.Kattis.EstimatingtheAreaofaCircle;
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
            double r = double.Parse(input[0]);
            int m = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            
            if (r == 0 && m == 0 && c == 0)
                break;
            
            double real = Math.PI * r * r;
            double sim = Math.Pow(r * 2, 2) * (double)c / m;
            
            Console.WriteLine($"{real:F17} {sim:F17}");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Estimating the Area of a Circle");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}