// Combination Lock
namespace CompetitiveProgramming.CodeForces.ACombinationLock;
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
        int digits = int.Parse(Console.ReadLine());
        string initial = Console.ReadLine();
        string final = Console.ReadLine();
        
        int moves = 0;
        for (int position = 0; position < digits; position++)
        {
            int diff = Math.Abs(initial[position] - final[position]);
            if (diff > 5) diff = 10 - diff;
            moves += diff;
        }
        
        Console.WriteLine(moves);
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
        StyleHelper.Title("Combination Lock");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}