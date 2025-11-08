// Reconnaissance 2
namespace CompetitiveProgramming.CodeForces.ReconnaissanceTwo;
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
        int n = int.Parse(Console.ReadLine());
        int[] heights = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int minDiff = Math.Abs(heights[0] - heights[n - 1]);
        int index = n - 1;
        
        for (int k = 0; k < n - 1; k++)
        {
            int diff = Math.Abs(heights[k] - heights[k + 1]);
            if (diff < minDiff)
            {
                minDiff = diff;
                index = k;
            }
        }
        
        Console.WriteLine($"{index + 1} {(index + 1) % n + 1}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reconnaissance 2");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}