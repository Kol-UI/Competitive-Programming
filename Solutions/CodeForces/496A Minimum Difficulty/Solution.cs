// Minimum Difficulty
namespace CompetitiveProgramming.CodeForces.MinimumDifficulty;
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
        
        int minNewGap = 1001;
        int maxCurrentGap = heights[1] - heights[0];
        
        for (int position = 1; position < n - 1; position++)
        {
            int newGap = heights[position + 1] - heights[position - 1];
            if (newGap < minNewGap) minNewGap = newGap;
            
            int currentGap = heights[position + 1] - heights[position];
            if (currentGap > maxCurrentGap) maxCurrentGap = currentGap;
        }
        
        int result = Math.Max(maxCurrentGap, minNewGap);
        Console.WriteLine(result);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Difficulty");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}