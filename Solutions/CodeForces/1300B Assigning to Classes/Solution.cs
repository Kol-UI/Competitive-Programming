// Assigning to Classes
namespace CompetitiveProgramming.CodeForces.AssigningtoClasses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int tc = int.Parse(Console.ReadLine()!);
        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!) * 2;
            int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            Array.Sort(v);
            Console.WriteLine(v[n / 2] - v[n / 2 - 1]);
        }
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Assigning to Classes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}