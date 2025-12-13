// Circle Game
namespace CompetitiveProgramming.CodeForces.CircleGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            if (n % 2 == 1)
            {
                Console.WriteLine("Mike");
                continue;
            }
            
            int minIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < numbers[minIndex]) minIndex = i;
            }
            
            Console.WriteLine(minIndex % 2 == 1 ? "Mike" : "Joe");
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
        StyleHelper.Title("Circle Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}