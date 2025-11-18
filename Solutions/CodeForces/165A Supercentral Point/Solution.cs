// Supercentral Point
namespace CompetitiveProgramming.CodeForces.SupercentralPoint;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<(int, int)> points = new List<(int, int)>();
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            points.Add((x, y));
        }
        
        int centralCount = 0;
        
        for (int a = 0; a < n; a++)
        {
            int x = points[a].Item1;
            int y = points[a].Item2;
            bool[] neighbors = new bool[4];
            
            for (int b = 0; b < n; b++)
            {
                if (b == a) continue;
                int bx = points[b].Item1;
                int by = points[b].Item2;
                
                if (bx == x && by < y) neighbors[0] = true;
                else if (bx == x && by > y) neighbors[1] = true;
                else if (bx < x && by == y) neighbors[2] = true;
                else if (bx > x && by == y) neighbors[3] = true;
                
                if (neighbors[0] && neighbors[1] && neighbors[2] && neighbors[3])
                {
                    centralCount++;
                    break;
                }
            }
        }
        
        Console.WriteLine(centralCount);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Supercentral Point");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}