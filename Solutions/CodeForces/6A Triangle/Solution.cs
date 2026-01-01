// Triangle
namespace CompetitiveProgramming.CodeForces.Triangle;
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
        int[] lengths = new int[4];
        string[] inputs = Console.ReadLine().Split();
        for (int i = 0; i < 4; i++)
        {
            lengths[i] = int.Parse(inputs[i]);
        }
        
        Array.Sort(lengths);
        
        int firstTriangleCheck = lengths[1] + lengths[2] - lengths[3];
        int secondTriangleCheck = lengths[0] + lengths[1] - lengths[2];
        
        string result;
        if (firstTriangleCheck > 0 || secondTriangleCheck > 0)
        {
            result = "TRIANGLE";
        }
        else if (firstTriangleCheck == 0 || secondTriangleCheck == 0)
        {
            result = "SEGMENT";
        }
        else
        {
            result = "IMPOSSIBLE";
        }
        
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
        StyleHelper.Title("Triangle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}