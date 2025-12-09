// Shortest path of the king
namespace CompetitiveProgramming.CodeForces.Shortestpathoftheking;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();
        
        int horizontalDistance = Math.Abs(start[0] - end[0]);
        int verticalDistance = Math.Abs(start[1] - end[1]);
        char horizontalDirection = start[0] < end[0] ? 'R' : 'L';
        char verticalDirection = start[1] < end[1] ? 'U' : 'D';
        
        int totalMoves = Math.Max(horizontalDistance, verticalDistance);
        Console.WriteLine(totalMoves);
        
        for (int move = 0; move < totalMoves; move++)
        {
            if (move < horizontalDistance) Console.Write(horizontalDirection);
            if (move < verticalDistance) Console.Write(verticalDirection);
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest path of the king");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}