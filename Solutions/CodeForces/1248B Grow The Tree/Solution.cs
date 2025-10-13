// Grow The Tree
namespace CompetitiveProgramming.CodeForces.GrowTheTree;
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
        int n = int.Parse(Console.ReadLine());
        long[] sticks = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        Array.Sort(sticks);
        
        long firstHalfSum = 0;
        long secondHalfSum = 0;
        
        for (int i = 0; i < n / 2; i++)
        {
            firstHalfSum += sticks[i];
        }
        
        for (int i = n / 2; i < n; i++)
        {
            secondHalfSum += sticks[i];
        }
        
        long result = firstHalfSum * firstHalfSum + secondHalfSum * secondHalfSum;
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
        StyleHelper.Title("Grow The Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}