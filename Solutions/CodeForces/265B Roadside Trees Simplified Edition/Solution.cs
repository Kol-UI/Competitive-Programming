// Roadside Trees (Simplified Edition)
namespace CompetitiveProgramming.CodeForces.RoadsideTreesSimplifiedEdition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        const int timeToEat = 1;
        const int timeToJump = 1;

        int numTrees = int.Parse(Console.ReadLine());
        int[] heights = new int[numTrees];
        
        for (int k = 0; k < numTrees; k++)
        {
            heights[k] = int.Parse(Console.ReadLine());
        }

        int currentHeight = 0;
        long totalTime = -1;

        for (int t = 0; t < numTrees; t++)
        {
            if (currentHeight > heights[t])
            {
                totalTime += currentHeight - heights[t] + timeToJump;
            }
            else
            {
                totalTime += timeToJump + heights[t] - currentHeight;
            }
            currentHeight = heights[t];
            totalTime += timeToEat;
        }

        Console.WriteLine(totalTime);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Roadside Trees (Simplified Edition)");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}