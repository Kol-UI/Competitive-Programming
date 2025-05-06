// Young Physicist
namespace CompetitiveProgramming.CodeForces.YoungPhysicist;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int row = int.Parse(Console.ReadLine()!);
        int x = 0, y = 0, z = 0;
        for (int i = 0; i < row; i++)
        {
            string[] coordinates = Console.ReadLine()!.Split();
            x += int.Parse(coordinates[0]);
            y += int.Parse(coordinates[1]);
            z += int.Parse(coordinates[2]);
        }
        Console.WriteLine(x == 0 && y == 0 && z == 0 ? "YES" : "NO");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Young Physicist");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}