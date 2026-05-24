// Polygon Area
namespace CompetitiveProgramming.Kattis.PolygonArea;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static double Zipper(List<(double, double)> v)
    {
        double total = 0;
        int n = v.Count;
        
        for (int i = 0, j = 1; i < n; i++, j = (j + 1) % n)
        {
            total += v[i].Item1 * v[j].Item2;
            total -= v[i].Item2 * v[j].Item1;
        }
        
        return total / 2;
    }
    
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;
            
            List<(double, double)> v = new List<(double, double)>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                double x = double.Parse(input[0]);
                double y = double.Parse(input[1]);
                v.Add((x, y));
            }
            
            double ans = Zipper(v);
            
            if (ans < 0)
                Console.Write("CW ");
            else
                Console.Write("CCW ");
            
            Console.WriteLine($"{Math.Abs(ans):F1}");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Polygon Area");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}