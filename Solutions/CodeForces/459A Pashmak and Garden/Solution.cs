// Pashmak and Garden
namespace CompetitiveProgramming.CodeForces.PashmakandGarden;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        int x1 = int.Parse(input[0]);
        int y1 = int.Parse(input[1]);
        int x2 = int.Parse(input[2]);
        int y2 = int.Parse(input[3]);

        if (x1 == x2)
        {
            int dif = Math.Abs(y1 - y2);
            Console.WriteLine($"{x1 + dif} {y1} {x2 + dif} {y2}");
        }
        else if (y1 == y2)
        {
            int dif = Math.Abs(x1 - x2);
            Console.WriteLine($"{x1} {y1 + dif} {x2} {y2 + dif}");
        }
        else
        {
            if (Math.Abs(x2 - x1) == Math.Abs(y2 - y1))
            {
                Console.WriteLine($"{x1} {y2} {x2} {y1}");
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pashmak and Garden");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}