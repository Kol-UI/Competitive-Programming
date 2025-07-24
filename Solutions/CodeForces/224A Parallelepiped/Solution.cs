// Parallelepiped
namespace CompetitiveProgramming.CodeForces.Parallelepiped;
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
        int[] values = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int x = values[0], y = values[1], z = values[2];
        Console.WriteLine(4 * (Math.Sqrt(x * y / (double)z) + Math.Sqrt(x * z / (double)y) + Math.Sqrt(y * z / (double)x)));
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
        StyleHelper.Title("Parallelepiped");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}