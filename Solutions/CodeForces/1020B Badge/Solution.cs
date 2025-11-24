// Badge
namespace CompetitiveProgramming.CodeForces.Badge;
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
        int[] a = new int[n + 1];
        string[] input = Console.ReadLine().Split();
        for (int i = 1; i <= n; i++)
        {
            a[i] = int.Parse(input[i - 1]);
        }
        
        for (int start = 1; start <= n; start++)
        {
            HashSet<int> visited = new HashSet<int>();
            int current = start;
            while (!visited.Contains(current))
            {
                visited.Add(current);
                current = a[current];
            }
            Console.Write(current + " ");
        }
        
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Badge");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}