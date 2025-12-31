// Beru-taxi
namespace CompetitiveProgramming.CodeForces.Berutaxi;
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
        string[] firstLine = Console.ReadLine().Split();
        double a = double.Parse(firstLine[0]);
        double b = double.Parse(firstLine[1]);
        
        int n = int.Parse(Console.ReadLine());
        double min = 1000;
        
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();
            double x = double.Parse(line[0]);
            double y = double.Parse(line[1]);
            double v = double.Parse(line[2]);
            
            double dist = Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b));
            double time = dist / v;
            if (time < min) min = time;
        }
        
        Console.WriteLine(min.ToString("F8"));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Beru-taxi");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}