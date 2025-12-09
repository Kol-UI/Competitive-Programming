// Contest Start
namespace CompetitiveProgramming.CodeForces.ContestStart;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < testCases; i++)
        {
            long[] inputs = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long count = inputs[0];
            long interval = inputs[1];
            long duration = inputs[2];
            
            long limit = duration / interval;
            if (limit > count) limit = count;
            
            long result = count * limit - limit * (limit + 1) / 2;
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Contest Start");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}