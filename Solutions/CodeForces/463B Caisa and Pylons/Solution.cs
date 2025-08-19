// Caisa and Pylons
namespace CompetitiveProgramming.CodeForces.CaisaandPylons;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine());
        int output = 0;
        
        string[] heights = Console.ReadLine().Split();
        for (int p = 0; p < n; p++)
        {
            int height = int.Parse(heights[p]);
            output = Math.Max(output, height);
        }
        
        Console.WriteLine(output);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Caisa and Pylons");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}